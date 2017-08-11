using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http.Server;

namespace WebListenerServerDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseWebListener(opt =>
                    {
                        opt.ListenerSettings.Authentication.Schemes = AuthenticationSchemes.None;
                        opt.ListenerSettings.Authentication.AllowAnonymous = true;
                    }

                )
                .Build();

            host.Run();
        }
    }
}
