using Xunit;
using Forum.Services;
using Forum.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Forum.Data;

namespace Forum.Tests
{
    public class PostServiceTests
    {
        private PostService postService;
        private ApplicationDbContext context;

        public PostServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase") // Unique name for each test
            .Options;
            context = new ApplicationDbContext(options);

            postService = new PostService(context);
        }

        /*
        [Fact]
        public void TestAddPost() 
        {
            Post testPost = new() { Id = 3, Title = "Test Post", Content = "Test Content" };

            Boolean test = postService.AddPost(testPost);

            foreach(var post in context.Posts)
            {
                Console.WriteLine(post.ToString());
            }


            Assert.True(test);
        }

        [Fact]
        public void TestRemovePost() {
             Post testPost = new() { Id = 3, Title = "Test Post", Content = "Test Content" };

            Boolean test = postService.AddPost(testPost);

            Assert.True(postService.RemovePost(3));
            Assert.False(postService.RemovePost(3));
        }

        [Fact]
        public void TestGetPost()
        {
            // Arrange
            var expectedPost = new Post() { Id = 3, Title = "Test Post", Content = "Test Content", DateCreated = DateTime.UtcNow };

            // TODO: Set up your mock data or service to return the expectedPost when GetPost is called

            // Act
            var result = postService.GetRecentPosts(1);

            // Assert
            Assert.Equal(expectedPost, result.First());
        }
        */
    }
}
