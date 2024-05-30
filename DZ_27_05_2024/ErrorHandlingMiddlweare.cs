namespace DZ_27_05_2024
{
    public class ErrorHandlingMiddlweare
    {
        readonly RequestDelegate next;
        public ErrorHandlingMiddlweare(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await next.Invoke(context);
            if (context.Response.StatusCode == 403)
                await context.Response.WriteAsync("Access Danied");
            else if (context.Response.StatusCode == 404)
                await context.Response.WriteAsync("Not Found");
        }
    }
}