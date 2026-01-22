using ApiAutomationTests.Pages;

namespace ApiAutomationTests.Core
{
    public static class ApiPageFactory
    {
        public static object GetApi(ApiType type)
        {
            return type switch
            {
                ApiType.Posts => new PostsApiPage(),
                ApiType.Users => new UsersApiPage(),
                _ => throw new ArgumentException("Invalid API type")
            };
        }
    }
}
