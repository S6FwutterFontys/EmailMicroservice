using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailMicroservice.Helper;
using EmailMicroservice.MessageHandlers;
using EmailMicroservice.Services;
using MessageBroker;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmailMicroservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<EmailSettings>(Configuration.GetSection(nameof(EmailSettings)));
            services.AddMessageConsumer(Configuration["MessageQueueSettings:Uri"], 
                Configuration["MessageQueueSettings:QueueName"], 
                builder => builder.WithHandler<RegisterEmailHandler>("RegisterUser"));
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IEmailGenerator, EmailGenerator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }
    }
}
