namespace DZ_27_05_2024
{
    public class RoutingMiddleware
    {
        
        public RoutingMiddleware(RequestDelegate _)
        {
            
        }
        public async Task InvokeAsync(HttpContext context,TimeService service)
        {
            
            string path = context.Request.Path;
            if (path == "/picture")
            {
                Console.WriteLine($" Time: {service.GetTime()}: Картинка загружена");
                await context.Response.WriteAsJsonAsync($"Картинка загружена");
            }
            else if (path == "/now")
            {
                Console.WriteLine($" Time: {service.GetTime()} Date: {DateTime.Now.ToLongDateString()}");
                await context.Response.WriteAsJsonAsync($"Date: {DateTime.Now.ToLongDateString()}");
            }
            else if (path == "/clock")
            {
                Console.WriteLine($" Time: {service.GetTime()} загрузили часы");
                await context.Response.SendFileAsync("C:\\HTML\\JS\\clock.html");
            }
            else if (path == "/time")
            {
                Console.WriteLine($"Time: {service.GetTime()}");
                await context.Response.WriteAsJsonAsync($"Time: {service.GetTime()}");
            }
            else
                context.Response.StatusCode = 404;
        }
    }
}
