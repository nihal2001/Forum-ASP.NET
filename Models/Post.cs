using System.ComponentModel.DataAnnotations;

namespace Forum.Models {
    public class Post {
        [Key]
        public int Id { get; set; }    
        public required string Title { get; set;}
        public required string Content { get; set; }
        
        public  required List<Comment> Comments { get; set; }

        public required User PostUser { get; set; }

        public required DateTime DateCreated { get; set; }

        public override string ToString() {
            return "Id: " + Id + " | Title: " + Title + " | Content: " + Content;
        }

    }

    
    public class Comment {
        [Key]
        public required int Id { get; set; }
        public required String Content { get; set; }
        public required String User { get; set; }
    }
    
    
}