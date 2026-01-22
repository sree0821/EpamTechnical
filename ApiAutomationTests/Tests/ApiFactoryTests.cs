using NUnit.Framework;
using System.Net;
using ApiAutomationTests.Core;
using ApiAutomationTests.Pages;

namespace ApiAutomationTests.Tests
{
    [TestFixture]
    public class ApiFactoryTests
    {
        private PostsApiPage postsApi;
        private UsersApiPage usersApi;

        [SetUp]
        public void Setup()
        {
            postsApi = (PostsApiPage)ApiPageFactory.GetApi(ApiType.Posts);
            usersApi = (UsersApiPage)ApiPageFactory.GetApi(ApiType.Users);
        }

        [Test]
        public void ValidatePostUsingFactory()
        {
            Assert.That(postsApi.GetPostStatusCode(1), Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void ValidateUserUsingFactory()
        {
            Assert.That(usersApi.GetUserStatusCode(1), Is.EqualTo(HttpStatusCode.OK));
            Assert.That(usersApi.GetUserName(1), Is.Not.Empty);
        }
    }
}
