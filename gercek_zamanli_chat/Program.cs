using Microsoft.AspNetCore.SignalR;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();


builder.Services.AddCors(options =>   //Connection id requried hatasi icin 
                                        //farkli cozum icn cors ekledik
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5142/chatHub")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
            
    });
});
var app = builder.Build();
app.UseCors();
// 
app.MapHub<ChatHub>("chatHub");

app.Run();
