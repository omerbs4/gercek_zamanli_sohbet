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
              .WithOrigins("http://127.0.0.1:3000","http://localhost:3000")
               // Live Server portunu ekle
              .SetIsOriginAllowed(origin => true);
    });
});

var app = builder.Build();
app.UseCors();

app.MapHub<ChatHub>("/chat_hub");

app.Run();
