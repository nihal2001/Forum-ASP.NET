namespace Forum.Models {
    public class Post {
        private String id { get; set; }    
        private String title { get; set;}
        private User user { get; set; }
        private String content { get; set; }
        private List<Comment> comments;

    }

    public class Comment {
        private String id;
        private String content;
        private String user;
    }
}