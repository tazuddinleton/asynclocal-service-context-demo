namespace ServiceContextDemo;

public class ServiceContextMiddleware
{
    private readonly RequestDelegate _next;
    public ServiceContextMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        ServiceContext.Current = context.RequestServices;
        try
        {
            await _next(context);
        }
        finally
        {
            ServiceContext.Current = null;
        }
    }
}