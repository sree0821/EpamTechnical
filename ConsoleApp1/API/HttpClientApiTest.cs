using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace IncubationProject.API
{
    public class HttpClientApiTest
    {
        public async Task ExecuteAsync()
        {
            HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/posts/1";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Status Code Verification: PASSED (200 OK)");
            }
            else
            {
                Console.WriteLine($"Status Code Verification: FAILED ({response.StatusCode})");
            }

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
    }
}
