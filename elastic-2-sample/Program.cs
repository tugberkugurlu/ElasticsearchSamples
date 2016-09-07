using System;
using System.IO;
using Elasticsearch.Net;
using Microsoft.Extensions.PlatformAbstractions;
using Nest;

namespace ConsoleApplication
{
    public class Program
    {
        // Connecting: https://www.elastic.co/guide/en/elasticsearch/client/net-api/2.x/connecting.html
        // Dangerous String Replace: https://github.com/elastic/elasticsearch-net/issues/2245

        public static void Main(string[] args)
        {
            var loopupTerm = "star \"";
            var client = new ElasticLowLevelClient();
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