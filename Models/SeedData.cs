using financial_chat.Data;
using Microsoft.AspNetCore.Identity;

namespace financial_chat.Models
{
    public class SeedData
    {
        private ChatContext _context;
        private ApplicationDbContext _Icontext;

        public SeedData(ChatContext context, ApplicationDbContext _Icontext)
        {
            _context = context;
            _Icontext = _Icontext;

        }

        public async Task Seed()
        {
            if (!_context.Rooms.Any())
            {
                _context.Rooms.Add(new Room("Chat room 1"));
                _context.Rooms.Add(new Room("Chat room 2"));
                _context.Rooms.Add(new Room("Chat room 3"));
                _context.Rooms.Add(new Room("Chat room 4"));

                await _context.SaveChangesAsync();
            }
            if (!_context.Posts.Any())
            {
                var Room1 = _context.Rooms.Find("Fernando");

                _context.Posts.Add(new Post("Hola 1", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola 2", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola 3", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola 4", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola 5 ", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Test", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola aaa", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola!", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("HolaGG ", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola mundo", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Como estan", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola buenas noches", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Holaaaaaa", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola sasa", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola asa a", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola asasas", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola asasasa", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola Mundhi", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola A", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola B", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola B", DateTime.Now, Room1, "Fernando"));
                _context.Posts.Add(new Post("Hola A", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola B", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola B", DateTime.Now, Room1, "Mateo"));
                _context.Posts.Add(new Post("Hola A", DateTime.Now, Room1, "Mateo"));
                await _context.SaveChangesAsync();
            }
        }
    }
}
