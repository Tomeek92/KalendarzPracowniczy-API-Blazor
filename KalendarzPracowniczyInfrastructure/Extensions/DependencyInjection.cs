﻿using KalendarzPracowniczyDomain.Interfaces;
using KalendarzPracowniczyInfrastructure.Repositories;
using KalendarzPracowniczyInfrastructureDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KalendarzPracowniczyInfrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KalendarzPracowniczyDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("KalendarzPracowniczyDbContext")));

            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}