using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace financial_chat.Models
{
    public class Post
    {
        [Key]
        public int IdPost { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public Room Room { get; set; }
        public string UserID { get; set; }

        public Post()
        {
        }

        public Post(string message, DateTime created, Room room, string ID)
        {
            Message = message;
            Created = created;
            Room = room;
            UserID = ID;
        }
    }
}
