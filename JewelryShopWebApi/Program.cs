
using JewelryShopWebApi.Models;
using JewelryShopWebApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace JewelryShopWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //If a loop is detected, the serializer will throw an exception! Very good. 
            builder.Services.AddControllers().AddJsonOptions(option => 
            option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddTransient<OrderService>(); //We use addtransient because we're always getting the data fresh from DB
            builder.Services.AddTransient<ProductService>();

            builder.Services.AddRazorPages();
            string connectionString = builder.Configuration.GetConnectionString("MySQLConnection");
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
