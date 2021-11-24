using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using WebApi.DbOperations;
using Microsoft.EntityFrameworkCore;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.UpdateBook;
using WebApi.BookOperations.GetBook;
using WebApi.BookOperations.DeleteBook;
using System.Reflection;
using FluentValidation;
using WebApi.BookOperations.QueryModels;
using WebApi.Middlewares;
using WebApi.Services;

namespace WebApi
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
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
            });

            services.AddSingleton<ILoggerService,ConsoleLogger>();
            services.AddScoped<IGetBookByIdQuery, GetBookByIdQuery>();
            services.AddScoped<AbstractValidator<BookInsertModel>, CreateBookCommandValidator>();
            services.AddScoped<AbstractValidator<BookUpdateModel>, UpdateBookCommandValidator>();
            services.AddScoped<AbstractValidator<int>,DeleteBookCommandValidator>();
            services.AddScoped<IGetBooksQuery, GetBooksQuery>();
            services.AddScoped<ICreateBookCommand, CreateBookCommand>();
            services.AddScoped<IUpdateBookCommand, UpdateBookCommand>();
            services.AddScoped<IDeleteBookCommand, DeleteBookCommand>();
            services.AddDbContext<InMemoryDbContext>(options=>options.UseInMemoryDatabase(databaseName:"BookStoreDb"));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCustomExceptionMiddle();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
