using Microsoft.AspNetCore.SignalR;
using ProductionLineBackend.Classes;

namespace ProductionLineBackend.Hubs;

public class DashboardHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        Dashboard Dashboard = new Dashboard(Context.ConnectionId, this);
        Worker.AttachMachineToDashboard(Dashboard);
        
        Console.WriteLine($"Dashboard connected to {Context.ConnectionId}");
        await Clients.Caller.SendAsync("init", Worker.Machines);
        await Clients.Caller.SendAsync("test", "Debug message" );
    }
}