using System.Net.Http.Headers;
using System.Threading.Tasks;
using financial_chat.Models;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace financial_chat.Hubs
{
    public class ChatHub: Hub
    {
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
    }
}
