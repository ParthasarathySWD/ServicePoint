using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace ServicePointManager
{
    class Program
    {
        static void Main(string[] args)
        {
            sendRequest();
            Console.ReadLine();
        }


        public static async void sendRequest()
        {
            try
            {
                Console.WriteLine($"Environment.Version: {Environment.Version}");
                Console.WriteLine($"ServicePointManager.SecurityProtocol: {System.Net.ServicePointManager.SecurityProtocol}");
                Console.WriteLine($"Downloading from https://www.staging.direct2title.com");
                var client = new HttpClient();
                var str = await client.GetStringAsync("https://www.staging.direct2title.com");

                Console.WriteLine($"Success {str}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Exception: {ex.InnerException.Message}");
            }
        }
    }
}
