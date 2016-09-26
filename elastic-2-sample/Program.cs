using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Elasticsearch.Net;
using Microsoft.Extensions.PlatformAbstractions;
using Nest;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    [ElasticsearchType(Name = "movies")]
    public class MovieSearchItem 
    {
        /// <summary>
        /// Elasticsearch id of the document.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Id of the Movie inside the primary data storage system.
        /// </summary>
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrimaryId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public long RatingCount { get; set; }
        public IEnumerable<string> Tags { get; set; }

        [Nested]
        public IEnumerable<Actor> MainActors { get; set; }
    }

    public class Actor 
    {
        public string Name { get; set; }
        public string Playing { get; set; }
    }

    public class Program
    {
        // Connecting: https://www.elastic.co/guide/en/elasticsearch/client/net-api/2.x/connecting.html
        // Dangerous String Replace: https://github.com/elastic/elasticsearch-net/issues/2245

        public static void Main(string[] args)
        {
            var elasticClient = new ElasticClient();
            var indexName = "movie-app";
            elasticClient.DeleteIndex(indexName);
            LoadMovies(elasticClient, indexName);
            var movies = SearchForTerm(elasticClient, "star");

            var loopupTerm = "star";
            var client = new ElasticLowLevelClient();
            UnsafeQueryTemplateSample(client, loopupTerm);
        }

        private static void LoadMovies(IElasticClient elasticClient, string indexName) 
        {
            var settingsResponse = elasticClient.GetIndexSettingsAsync(x => x.Index(indexName)).Result;
            if (settingsResponse.ServerError?.Status == 404)
            {
                var response = elasticClient.CreateIndexAsync(indexName, d => d
                    .Mappings(ms => ms
                        .Map<MovieSearchItem>(m => m.AutoMap())
                    )
                ).Result;

                if (response.IsValid == false)
                {
                    throw new Exception(string.Format("{0}: {1}", 
                        response.ServerError.Status,
                        response.ServerError.Error), response.OriginalException);
                }
            }

            var movies = GetMovies().ToList();
            foreach (var movie in movies) elasticClient.Index(movie, i => i.Index(indexName));
        } 

        private static IEnumerable<MovieSearchItem> SearchForTerm(IElasticClient elasticClient, string lookupTerm) 
        {
            var searchRequest = new SearchRequest<MovieSearchItem>
            {
                From = 0,
                Size = 50,
                Query = new TermQuery { Field = Infer.Field<MovieSearchItem>(m => m.Name), Value = "star" }
            };

            using(var stream = new MemoryStream())
            {
                elasticClient.Serializer.Serialize(searchRequest, stream);
                stream.Seek(0, SeekOrigin.Begin);
                
                using(var reader = new StreamReader(stream)) 
                {
                    Console.WriteLine("Query to run:");                    
                    Console.WriteLine(reader.ReadToEnd());
                }
            }

            var searchResult = elasticClient.Search<MovieSearchItem>(searchRequest);

            return searchResult.Hits.Select(x => x.Source);
        }

        private static IEnumerable<MovieSearchItem> GetMovies() 
        {
            var folderPath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "movies");
            var files = Directory.EnumerateFiles(folderPath, "*.json", SearchOption.TopDirectoryOnly);
            foreach (var filePath in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(filePath);

                using(var file = File.OpenRead(filePath))
                using(var reader = new StreamReader(file))
                {
                    var content = reader.ReadToEnd();
                    var movie = JsonConvert.DeserializeObject<MovieSearchItem>(content);
                    movie.PrimaryId = fileName;

                    yield return movie;
                }
            }
        }

        private static void UnsafeQueryTemplateSample(ElasticLowLevelClient client, string loopupTerm) 
        {
            var aggsQueryFilePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "aggs-query.json");
            var queryTemplate = ReadToEnd(aggsQueryFilePath);
            var queryToIssue = queryTemplate.Replace("@lookupTerm", $"\"{loopupTerm}\"");
            var result = client.Search<string>(queryToIssue);

            System.Console.WriteLine(result.HttpStatusCode);
            System.Console.WriteLine(result.Body);
        }

        private static string ReadToEnd(string fullPath) 
        {
            using(var stream = File.OpenRead(fullPath))
            using(var reader = new StreamReader(stream)) 
            {
                return reader.ReadToEnd();
            }
        }
    }
}