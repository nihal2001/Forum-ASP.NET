using System.ComponentModel.DataAnnotations;

namespace Forum.Models {
    public class Post {
        [Key]
        public int Id { get; set; }    
        public required string Title { get; set;}
        //private User User { get; set; }
        public required string Content { get; set; }
        //private List<Comment> comments;

        public User? PostUser { get; set; }

        public DateTime DateCreated { get; set; }

        public override string ToString() {
            return "Id: " + Id + " | Title: " + Title + " | Content: " + Content;
        }

    }

    /*
    public class Comment {
        private String Id { get; set; }
        private String Content { get; set; }
        private String User { get; set; }
    }
    */
    
}