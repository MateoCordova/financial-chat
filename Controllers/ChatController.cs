using financial_chat.Data;
using financial_chat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace financial_chat.Controllers
{
    public class ChatController : Controller
    {
        private static ChatContext _context;
        private static UserManager<IdentityUser> _userManager;

        public ChatController(ChatContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            ViewBag.Rooms = _context.Rooms.ToList();
            return View();
        }
        [Authorize]
        public IActionResult Room(int room)
        {
            ViewBag.Room = _context.Rooms.Find(room);
            return View("Room",room);
        }

        public JsonResult ShowHistorial(int room)
        {
            var messages = _context.Posts.Include(p => p.Room).Where(p => p.Room.IdRoom == room).OrderByDescending(p => p.Created).Take(50).ToList();

            return Json(messages);
        }

        public IActionResult Seed()
        {
            if (!_context.Rooms.Any())
            {
                _context.Rooms.Add(new Room("Chat room 1"));
                _context.Rooms.Add(new Room("Chat room 2"));
                _context.Rooms.Add(new Room("Chat room 3"));
                _context.Rooms.Add(new Room("Chat room 4"));

                _context.SaveChanges();
            }

            if (!_context.Posts.Any())
            {
                var Room1 = _context.Rooms.Find(1);

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
                _context.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

    }
}
