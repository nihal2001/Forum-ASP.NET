using System.Collections;
using Forum.Services;
using Forum.Models;
using Forum.Data;

namespace Forum.Services {

    public class PostService : IPostService
    {
        private readonly ApplicationDbContext context;
        public PostService(ApplicationDbContext context) 
        {
            this.context = context;
        }

        public bool AddPost(Post post) 
        {
            try 
            {
                context.Posts.Add(post);
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

public bool RemovePost(int id)
{
    try
    {
        var post = context.Posts.Find(id);
        if (post == null)
        {
            return false;
        }

        context.Posts.Remove(post);
        context.SaveChanges();
        return true;
    }
    catch
    {
        // Log the exception here
        return false;
    }
}

        public IEnumerable<Post> GetRecentPosts(int count) 
        {
            return null;
        }

        public IEnumerable<Post> GetRecentPosts(int count, string name) 
        {
            return null;
        }

        public IEnumerable<Post> GetRecentPostsByName(int count, string name)
        {
            throw new NotImplementedException();
        }

        public Post EditPost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}