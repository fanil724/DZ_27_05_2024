using DZ_27_05_2024;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<TimeService>();
var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddlweare>();
app.UseMiddleware<AuthenticationMiddleware>();
app.UseMiddleware<RoutingMiddleware>();

app.Run();
