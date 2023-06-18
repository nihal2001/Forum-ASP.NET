public interface IPostService
{
    IEnumerable<Post> GetRecentPosts(int count);
    // You can add other methods as needed
}
