using System;
using System.Collections.Generic;
using System.IO;
using Elasticsearch.Net;
using Microsoft.Extensions.PlatformAbstractions;
using Nest;

namespace ConsoleApplication
{
    [ElasticsearchType(Name = "movie")]
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
            var loopupTerm = "star \"";
            var client = new ElasticLowLevelClient();

            UnsafeQueryTemplateSample(client, loopupTerm);
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