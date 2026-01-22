using RestSharp;
using Newtonsoft.Json.Linq;
using ApiAutomationTests.Core;
using System.Net;

namespace ApiAutomationTests.Pages
{
    public class UsersApiPage
    {
        private readonly RestClient client;

        public UsersApiPage()
        {
            client = ApiClientSingleton.GetClient();
        }

        public HttpStatusCode GetUserStatusCode(int id)
        {
            var request = new RestRequest($"/users/{id}", Method.Get);
            return client.Execute(request).StatusCode;
        }

        public string GetUserName(int id)
        {
            var request = new RestRequest($"/users/{id}", Method.Get);
            var response = client.Execute(request);

            JObject json = JObject.Parse(response.Content);
            return json["name"].ToString();
        }
    }
}
