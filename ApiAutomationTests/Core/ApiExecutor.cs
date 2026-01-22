using RestSharp;

namespace ApiAutomationTests.Core
{
    public class ApiExecutor : IApiExecutor
    {
        private readonly RestClient client;

        public ApiExecutor(RestClient client)
        {
            this.client = client;
        }

        public RestResponse Execute(RestRequest request)
        {
            return client.Execute(request);
        }
    }
}
