using RestSharp;
using Newtonsoft.Json.Linq;
using ApiAutomationTests.Core;
using System.Net;

namespace ApiAutomationTests.Pages
{
    public class PostsApiPage
    {
        private readonly RestClient client;
        private readonly IApiExecutor apiExecutor;

        public PostsApiPage()
        {
            client = ApiClientSingleton.GetClient();
            var baseExecutor = new ApiExecutor(client);
            apiExecutor = new LoggingApiExecutorDecorator(baseExecutor);
        }

        private RestResponse ExecuteGetPost(int id)
        {
            var request = new RestRequest($"/posts/{id}", Method.Get);
            return client.Execute(request);
        }

        public HttpStatusCode GetPostStatusCode(int id)
        {
            return ExecuteGetPost(id).StatusCode;
        }

        public int GetPostId(int id)
        {
            var response = ExecuteGetPost(id);
            JObject json = JObject.Parse(response.Content);
            return json["id"].Value<int>();
        }

        public int GetUserId(int id)
        {
            var response = ExecuteGetPost(id);
            JObject json = JObject.Parse(response.Content);
            return json["userId"].Value<int>();
        }

        public bool IsTitlePresent(int id)
        {
            var response = ExecuteGetPost(id);
            JObject json = JObject.Parse(response.Content);
            return !string.IsNullOrEmpty(json["title"]?.ToString());
        }

        public RestResponse GetPostById(int id)
        {
            var request = new ApiRequestBuilder()
                            .WithEndpoint($"/posts/{id}")
                            .WithMethod(Method.Get)
                            .WithHeader("Accept", "application/json")
                            .Build();

            return client.Execute(request);
        }

        public HttpStatusCode GetStatusCode(int id)
        {
            var request = new ApiRequestBuilder()
                                .WithEndpoint($"/posts/{id}")
                                .WithMethod(Method.Get)
                                .WithHeader("Accept", "application/json")
                                .Build();

            var response = apiExecutor.Execute(request);
            return response.StatusCode;
        }
    }
}
