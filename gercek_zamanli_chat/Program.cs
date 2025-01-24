using Microsoft.AspNetCore.SignalR;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials()
              .WithOrigins("http://127.0.0.1:3000/", "http://localhost:5500"); // Live Server portunu ekle
    });
});
var app = builder.Build();
app.UseCors();
// SignalR hub'ını doğru endpoint ile tanımlayın
app.MapHub<ChatHub>("/chat_hub");

app.Run();
