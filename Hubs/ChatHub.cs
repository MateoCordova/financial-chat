using System.Net.Http.Headers;
using System.Threading.Tasks;
using financial_chat.Controllers;
using financial_chat.Data;
using financial_chat.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace financial_chat.Hubs
{
    public class ChatHub: Hub
    {
        private static ChatContext _context;

        public ChatHub(ChatContext context)
        {
            _context = context;
        }
        public async Task SendMessage(string room, string message)
        {
            
            if (Context.User.Identity != null)
            {
                if (message.Contains("/stock="))
                {
                    using (var client = new HttpClient())
                    {
                        string response = "";
                        string Baseurl = "https://stooq.com";
                        //Passing service base url
                        client.BaseAddress = new Uri(Baseurl);
                        client.DefaultRequestHeaders.Clear();
                        //Define request data format
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/csv"));
                        //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                        HttpResponseMessage Res = await client.GetAsync("q/l/?s=" + message.Split("/stock=")[1] + "&f=sd2t2ohlcv&h&e=csv");
                        //Checking the response is successful or not which is sent using HttpClient
                        if (Res.IsSuccessStatusCode)
                        {
                            //Storing the response details recieved from web api
                            var ApiResponse = Res.Content.ReadAsStringAsync().Result;
                            //Deserializing the response recieved from web api and storing into the Employee list
                            var Stock = new Stock(ApiResponse.Split('\n')[1],",");
                            response = string.Format("{0} quote is ${1:C2} pershare", Stock.Symbol, Stock.Open);
                        }
                        //returning the employee list to view
                        await Clients.Group(room).SendAsync("RecieveMessage", Context.User.Identity.Name, response);
                    }
                }
                else
                {
                    try
                    {
                        await NewMessage(message, Context.User.Identity.Name, room);
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    await Clients.Group(room).SendAsync("RecieveMessage", Context.User.Identity.Name, message);

                }
            }
  
        }

        public async Task AddToGroup(string room)
        {
            if (Context.User.Identity != null)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, room);
                await Clients.Group(room).SendAsync("RecieveMessage", Context.User.Identity.Name, "Se ha unido al chat");
            }
        }
        private async static Task NewMessage(string message, string User, string room)
        {
            Post Post = new Post();
            Post.Room = _context.Rooms.Find(int.Parse(room));
            Post.Message = message;
            Post.Created = DateTime.Now;
            Post.UserID = User;
            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();
        }
    }
}
