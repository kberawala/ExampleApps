using ExampleApps;
using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    private ICurrentUserService currentUserService;

    public ChatHub(ICurrentUserService currentUserService)
    {
        this.currentUserService = currentUserService;
    }

    public Task SendMessage(string user, string message)
    {
        string ipAddress = currentUserService.RemoteIpAddress;

        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}