
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PMS.Business;
using PMS.Business.Interfaces;
using PMS.Business.Mappers;
using PMS.Business.UnitOfWork;
using PMS.Business.UnitOfWork.Interfaces;
using PMS.Repository.PmsDbContext;
using PMS.Repository.Repositories;
using PMS.Repository.Repositories.Interfaces;

namespace PMS.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<PmsDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("PMS.WebAPI"));
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

           // builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run(); 
            
            // used for terminating the application and start listening for incoming HTTP requests
           // app.Use();// used for adding middleware components to the application's request processing pipeline
           // app.Map(); // used for defining endpoint routing in ASP.NET Core applications,
                       // allowing you to map incoming HTTP requests to
                       // specific handlers or controllers based on the URL pattern and HTTP method.
        }
    }
}
