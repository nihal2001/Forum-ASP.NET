using Forum.Models; 

namespace Forum.Services {
    public interface IPostService
    {
        
        void Post(Post post);

        IEnumerable<Post> GetRecentPosts(int count);
        
        IEnumerable<Post> GetRecentPosts(int count, String name);

    }
}
