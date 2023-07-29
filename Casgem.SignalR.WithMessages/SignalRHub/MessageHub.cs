using Microsoft.AspNetCore.SignalR;

namespace Casgem.SignalR.WithMessages.SignalRHub
{
    public class MessageHub : Hub
    {
        public async void SendChatMessage(string user, string message)
        {
            await Clients.All.SendAsync("Channel_huseyin_1", "Kullanıcı: " + user, "Mesajı: " + message);
        }
    }
}