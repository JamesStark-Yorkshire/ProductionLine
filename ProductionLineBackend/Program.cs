using ProductionLineBackend;
using ProductionLineBackend.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<DashboardHub>("/ws");

Worker.Init();
Worker.ChangeMachineStates();

app.Run();