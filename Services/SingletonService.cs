namespace ServiceContextDemo.Services;


public class SingletonService : ISingletonService
{
    public string Greet(string name)
    {
        var greeter = ServiceContext.GetRequiredService<IGreetingService>();
        var message = greeter.Greet(name);
        return $"From singleton: {message}";
    }
}

public interface ISingletonService
{
    string Greet(string name);
}