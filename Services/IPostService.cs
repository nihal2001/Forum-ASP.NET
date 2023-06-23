using Forum.Models; 

namespace Forum.Services {
    public interface IPostService
    {
        
        IEnumerable<Post> GetRecentPosts(int count);
        
        IEnumerable<Post> GetRecentPosts(int count, string name);

        Post EditPost(Post post);

        bool AddPost(Post post);

        bool RemovePost(int id);
    }
}
