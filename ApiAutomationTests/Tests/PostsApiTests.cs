using NUnit.Framework;
using System.Net;
using ApiAutomationTests.Pages;

namespace ApiAutomationTests.Tests
{
    [TestFixture]
    public class PostsApiTests
    {
        private PostsApiPage postsApi;

        [SetUp]
        public void Setup()
        {
            postsApi = new PostsApiPage();
        }

        [Test]
        public void GetPost_ShouldReturnCorrectId()
        {
            Assert.That(postsApi.GetPostStatusCode(1), Is.EqualTo(HttpStatusCode.OK));
            Assert.That(postsApi.GetPostId(1), Is.EqualTo(1));
        }

        [Test]
        public void GetPost_ShouldHaveValidUserId()
        {
            Assert.That(postsApi.GetUserId(1), Is.EqualTo(1));
        }

        [Test]
        public void GetPost_ShouldContainTitle()
        {
            Assert.IsTrue(postsApi.IsTitlePresent(1));
        }

        [Test]
        public void InvalidPost_ShouldReturnNotFound()
        {
            Assert.That(postsApi.GetPostStatusCode(9999), Is.EqualTo(HttpStatusCode.NotFound));
        }
    }
}
