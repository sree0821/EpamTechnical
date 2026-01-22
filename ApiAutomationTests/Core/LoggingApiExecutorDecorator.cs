using RestSharp;
using System;

namespace ApiAutomationTests.Core
{
    public class LoggingApiExecutorDecorator : IApiExecutor
    {
        private readonly IApiExecutor apiExecutor;

        public LoggingApiExecutorDecorator(IApiExecutor apiExecutor)
        {
            this.apiExecutor = apiExecutor;
        }

        public RestResponse Execute(RestRequest request)
        {
            Console.WriteLine($"[LOG] Executing API: {request.Resource}");

            var response = apiExecutor.Execute(request);

            Console.WriteLine($"[LOG] Status Code: {response.StatusCode}");
            return response;
        }
    }
}
