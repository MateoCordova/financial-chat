using Microsoft.AspNetCore.Mvc;

namespace financial_chat.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>()
        {
            {1,"Chat room 1" },
            {2,"Chat room 2" },
            {3,"Chat room 3" },
            {4,"Chat room 4" },
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Room(int room)
        {
            return View("Room",room);
        }
    }
}
