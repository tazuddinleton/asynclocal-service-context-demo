namespace ServiceContextDemo;

public class ServiceContext
{
    private static readonly AsyncLocal<IServiceProvider?> _current = new AsyncLocal<IServiceProvider?>();

    public static IServiceProvider? Current
    {
        get => _current.Value;
        internal set => _current.Value = value;
    }

    public static T GetRequiredService<T>() where T : notnull
    {
        var provider = Current ?? throw new InvalidOperationException("Service context is not initialized.");
        return provider.GetRequiredService<T>();
    }
}