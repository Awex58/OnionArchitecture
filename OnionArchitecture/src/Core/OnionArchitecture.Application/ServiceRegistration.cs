using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assmbly=Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assmbly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assmbly));
        }
    }
}
