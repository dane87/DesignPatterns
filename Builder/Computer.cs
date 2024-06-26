namespace Builder;

public sealed class Computer
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
    public string? OperatingSystem { get; set; }

    public Computer DeepClone()
    {
        var computer = (MemberwiseClone() as Computer)!;
        computer.Storage = new List<string>(Storage);
        return computer;
    }
}
