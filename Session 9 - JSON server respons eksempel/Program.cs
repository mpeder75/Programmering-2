using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Session_9___JSON_server_respons_eksempel
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";

            HttpClient httpClient = new HttpClient();

            try
            {
                // her forsøges at indhente et svar fra server
                var httpRsponseMessage = await httpClient.GetAsync(url);

                // her forsøges at læse svaret fra server
                string jsonResponse = await httpRsponseMessage.Content.ReadAsStringAsync();

                // svaret printes
                await Console.Out.WriteLineAsync(jsonResponse);
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync(e.Message);
            }

            Console.ReadLine();
        }
    }
}
