using Microsoft.AspNetCore.SignalR;
using ProductionLineBackend.Hubs;
using ProductionLineBasic.Classes;

namespace ProductionLineBackend.Classes;

public class Dashboard : Observer
{
    private readonly DashboardHub _hubContext;
    
    public Dashboard(string name, DashboardHub hubContext) : base(name)
    {
        this.name = name;
        _hubContext = hubContext;
    }
    
    public virtual async void Update(string state, string from)
    {
        await _hubContext.Clients.All.SendAsync("update", state, from);
    }
}