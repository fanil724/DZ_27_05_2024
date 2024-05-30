namespace DZ_27_05_2024
{
    public class AuthenticationMiddleware
    {
        readonly RequestDelegate next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var token =context.Request.Query["token"];
            if (token!="456")
                context.Response.StatusCode = 403;
            else
                await next.Invoke(context);
        }
    }
}