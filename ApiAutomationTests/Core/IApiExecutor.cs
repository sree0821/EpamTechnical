using RestSharp;

namespace ApiAutomationTests.Core
{
    public interface IApiExecutor
    {
        RestResponse Execute(RestRequest request);
    }
}
