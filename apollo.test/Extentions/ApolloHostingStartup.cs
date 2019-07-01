using Com.Ctrip.Framework.Apollo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

[assembly: HostingStartup(typeof(apollo.test.Extentions.ApolloHostingStartup))]
namespace apollo.test.Extentions
{
    public class ApolloHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Com.Ctrip.Framework.Apollo.Logging.LogManager.UseConsoleLogging(Com.Ctrip.Framework.Apollo.Logging.LogLevel.Trace);
            builder
                .ConfigureAppConfiguration((hostingContext, configbuilder) =>
                {
                    configbuilder
                        .AddApollo(configbuilder.Build().GetSection("apollo"))
                        .AddDefault();
                });
        }
    }
}
