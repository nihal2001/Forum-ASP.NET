using System.Collections;
using Forum.Services;
using Forum.Models;

namespace Forum.Services {

    public class PostService : IPostService
    {
        public PostService() {

        }

        public void Post(Post post) {

        }

        public IEnumerable<Post> GetRecentPosts(int count) {
            return null;
        }

        public IEnumerable<Post> GetRecentPosts(int count, String name) {
            return null;
        }
    }
}