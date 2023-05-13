using DominosRemake.Web;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => new GreetingService().GetGreetingMessage());

app.Run();
