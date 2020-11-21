using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace CreatingAHoldingPage
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseWelcomePage();
        }
    }
}
