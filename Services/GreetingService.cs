namespace ServiceContextDemo.Services;

public class GreetingService : IGreetingService
{
    public string Greet(string name)
    {
        return $"Hello {name}, from scoped service";
    }
}