using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using MohamedRefaat_TechnicalTest.Configurations;
using MohamedRefaat_TechnicalTest.Infra.Data.Context;
using MohamedRefaat_TechnicalTest.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);




var connectionString = builder.Configuration.GetConnectionString("Superhero");



builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.Configure<RouteOptions>(options =>
{
    options.ConstraintMap.Add("apiVersion", typeof(ApiVersionRouteConstraint));
});
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
DependencyContainer.RegisterServices(builder.Services);
AutoMapperConfig.RegisterAutoMapper(builder.Services);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyAllowSpecificOrigins",
        policy =>
        {
            //policy.WithOrigins("https://localhost:7062/", "http://localhost:7062/", "https://localhost:52300/", "https://localhost:52300", "https://localhost:50254/", "https://localhost:50254", "http://uatmmp.gonsure.com/",  "https://uatmmp.gonsure.com").AllowAnyHeader()
            //    .AllowAnyMethod();
            policy.WithOrigins("*").AllowAnyHeader()
               .AllowAnyMethod();
        });
});


var app = builder.Build();

app.UseWebSockets();




//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyAllowSpecificOrigins");


//app.UseHttpsRedirection();



app.UseAuthorization();



app.MapControllers();



await app.RunAsync();




