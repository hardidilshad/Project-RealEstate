using H_EstateAgency2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Hubs
{
    public class Chat : Hub
    {
        private readonly UserManager<ApplicationUser> _userManager;

    

        public  async  Task  SendMsg(string FullName,string Msg)
        {
            await Clients.All.SendAsync("ReceiveMessage", FullName, Msg);
        }



    }






}
