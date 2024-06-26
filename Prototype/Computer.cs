namespace Prototype;

public interface IClonable<T>
{
    T Clone();
    T DeepClone();
}

public sealed class OperatingSystem : IClonable<OperatingSystem>
{
    public string? Name { get; set; }
    public string? Version { get; set; }

    public OperatingSystem Clone()
    {
        return (MemberwiseClone() as OperatingSystem)!;
    }

    public OperatingSystem DeepClone()
    {
        return new OperatingSystem
        {
            Name = Name,
            Version = Version
        };
    }
}

public sealed class Computer : IClonable<Computer>//, IComputer
{
    public string? Processor { get; set; }
    public string? Memory { get; set; }
    public List<string> Storage { get; set; } = [];
    public string? Motherboard { get; set; }
    public string? PowerSupply { get; set; }
    public string? Case { get; set; }
    public string? GraphicsCard { get; set; }
    public string? Monitor { get; set; }
    public string? Keyboard { get; set; }
    public string? Mouse { get; set; }
    public OperatingSystem OperatingSystem { get; set; } = new OperatingSystem();

    public Computer Clone()
    {
        return (MemberwiseClone() as Computer)!;
    }

    public Computer DeepClone()
    {
        var clone = (MemberwiseClone() as Computer)!;

        clone.Storage = new List<string>(Storage);
        clone.OperatingSystem = OperatingSystem.Clone();

        return clone;
    }
}
