using AngleSharp.Common;
using com.sun.tools.javac.file;
using javax.management;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Form_builder_Test.DBHelper
{

    public class Item
    {

        public string Id { get; set; }
        public string startPage { get; set; }
        public string calculations { get; set; }
        public string expression { get; set; }

    }

    public static class CosmosHelper
    {
        private static string endpoint;
        private static string primarykey;
        private static CosmosClient cosmosClient;


        static CosmosHelper()
        {
            string endpoint = ConfigurationManager.AppSettings["endpoint"];
            string primarykey = ConfigurationManager.AppSettings["primarykey"];
            try
            {
                cosmosClient = new CosmosClient(endpoint, primarykey, new CosmosClientOptions() { AllowBulkExecution = true, ConnectionMode = ConnectionMode.Gateway });
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);

            }
        }

        public static string ReadData(string itemID, string xPath)
        {
            var container = cosmosClient.GetContainer("df-forms", "forms");
            ItemResponse<JObject> result = container.ReadItemAsync<JObject>(itemID, new PartitionKey(itemID)).Result;
            try
            {
                var parent = result.Resource.SelectToken(xPath);
                return parent.ToString();
            }

            catch(Exception e)
            {
                return e.Message;
            }

        }
        public static string ReadDataUAT(string itemID, string xPath)
        {
            var container = cosmosClient.GetContainer("df-forms", "responses_uat");
            ItemResponse<JObject> result = container.ReadItemAsync<JObject>(itemID, new PartitionKey(itemID)).Result;
            try
            {
                var parent = result.Resource.SelectToken(xPath);
                return parent.ToString();
            }

            catch (Exception e)
            {
                return e.Message;
            }

        }
        public static string ReadDataProd(string itemID, string xPath)
        {
            var container = cosmosClient.GetContainer("df-forms", "responses");
            ItemResponse<JObject> result = container.ReadItemAsync<JObject>(itemID, new PartitionKey(itemID)).Result;
            try
            {
                var parent = result.Resource.SelectToken(xPath);
                return parent.ToString();
            }

            catch (Exception e)
            {
                return e.Message;
            }

        }
        public static string ReadDataDraftData(string itemID, string xPath)
        {
            var container = cosmosClient.GetContainer("df-forms", "RunnerDraftData");
            ItemResponse<JObject> result = container.ReadItemAsync<JObject>(itemID, new PartitionKey(itemID)).Result;
            try
            {
                var parent = result.Resource.SelectToken(xPath);
                return parent.ToString();
            }

            catch (Exception e)
            {
                return e.Message;
            }

        }


        public static async Task ReadDataDAsync()
        {
            var container = cosmosClient.GetContainer("df-forms", "RunnerDraftData");

            string sql = $"SELECT c.formid FROM c WHERE c.formid= '56pnIa-NYs'";
            Task<FeedResponse<JObject>> response = container.GetItemQueryIterator<JObject>(new QueryDefinition(sql)).ReadNextAsync();
            var response2 = container.GetItemQueryIterator<JObject>(new QueryDefinition(sql)).ReadNextAsync();
            QueryDefinition queryDefinition = new QueryDefinition(sql);
            FeedIterator<Locations> queryResultSetIterator = container.GetItemQueryIterator<Locations>(queryDefinition);
            FeedResponse<Locations> currentResultSet = await queryResultSetIterator.ReadNextAsync();

            IEnumerable<Locations> currentResultSet1 = currentResultSet.Resource;


            List<Locations> mylist = new List<Locations>();
            while (queryResultSetIterator.HasMoreResults)
            {
              //  FeedResponse<Locations> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    currentResultSet.Resource.ToString();
               // IEnumerable<Locations> currentResultSet1 = currentResultSet.Resource;

                foreach (Locations x in currentResultSet)
                {
                    mylist.Add(x);
                    Console.WriteLine("\tRead {0}\n", x);
                }

            }
        }

    }

}

