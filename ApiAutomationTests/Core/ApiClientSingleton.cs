using RestSharp;

namespace ApiAutomationTests.Core
{
    public sealed class ApiClientSingleton
    {
        private static RestClient? client;

        private ApiClientSingleton() { }

        public static RestClient GetClient()
        {
            if (client == null)
            {
                client = new RestClient("https://jsonplaceholder.typicode.com");
            }
            return client;
        }
    }
}
