using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models.ORM.Context;
using SignalR.Models.ORM.Entities;


namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {

        private readonly Context _chatContext;

        public ChatHub(Context chatContext)
        {
            _chatContext = chatContext;
        }

        public override Task OnConnectedAsync()
        {
            var id = Context.ConnectionId;

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string message)
        {

            //string msg = message.Trim();
            await Clients.All.SendAsync("Receivemessage", message);
            //await Clients.Client("connectionid").SendAsync("ReceiveMessage", msg);
        }

        private User GetUser()
        {


            var email = Context.User.Claims.ToArray()[0].Value;

            var currentUser = _chatContext.Users.FirstOrDefault(x => x.EMail == email);

            return currentUser;
        }
        public async Task ChangeStatus(string status)
        {
            string userstatus = status.Substring(status.IndexOf("-") + 1);

            GetUser().OnlineStatus = userstatus;
            _chatContext.SaveChanges();

            string connectuserid = Context.User.Claims.ToArray()[1].Value;


            await Clients.All.SendAsync("UserStatus", userstatus, connectuserid);

            //await Clients.Client("asdasdasd").SendAsync("ReceiveMessage", msg);
        }
    }
}
