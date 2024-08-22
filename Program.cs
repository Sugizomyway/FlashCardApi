using Microsoft.EntityFrameworkCore;
using FlashCardApi.CoreServices.CoreData;
using FlashCardApi.CoreServices.ServiceInterface;
using FlashCardApi.Data;
using FlashCardApi.Infrastructure.DataRepository;
using FlashCardApi.Infrastructure.RepositoryInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
//There is a DB call FlashCardContext with the connection string in asspsettings
builder.Services.AddDbContext<FlashCardContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IFlashCardRepo,FlashCardRepo>();
builder.Services.AddTransient<IFlashCardService,FlashCardService>();

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
//Cross-Origin Resource Sharing: allow the angular app to communicate with the ASP.NET API
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
