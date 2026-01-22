using RestSharp;

namespace ApiAutomationTests.Core
{
    public class ApiRequestBuilder
    {
        private string endpoint;
        private Method method;
        private RestRequest request;

        public ApiRequestBuilder()
        {
            request = new RestRequest();
        }

        public ApiRequestBuilder WithEndpoint(string endpoint)
        {
            this.endpoint = endpoint;
            request.Resource = endpoint;
            return this;
        }

        public ApiRequestBuilder WithMethod(Method method)
        {
            this.method = method;
            request.Method = method;
            return this;
        }

        public ApiRequestBuilder WithHeader(string key, string value)
        {
            request.AddHeader(key, value);
            return this;
        }

        public ApiRequestBuilder WithQueryParam(string key, string value)
        {
            request.AddQueryParameter(key, value);
            return this;
        }

        public RestRequest Build()
        {
            return request;
        }
    }
}
