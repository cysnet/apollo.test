using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Com.Ctrip.Framework.Apollo;
using Com.Ctrip.Framework.Apollo.Enums;
using Com.Ctrip.Framework.Apollo.Logging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace apollo.test
{
    public class Program
    {
        public static void Main(string[] args)
        {
       
            //Com.Ctrip.Framework.Apollo.Logging.LogManager.Provider = new ConsoleLoggerProvider(Com.Ctrip.Framework.Apollo.Logging.LogLevel.Trace);
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.ConfigureAppConfiguration((hostingContext, builder) =>
                //{
                //    builder
                //    .AddApollo(builder.Build().GetSection("apollo"))
                //    .AddDefault();
                //})
                .UseStartup<Startup>()
                .Build();
    }
}
