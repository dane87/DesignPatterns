namespace Builder;

public sealed class ComputerBuilder
{
    private Computer _computer = new();

    public ComputerBuilder WithProcessor(string processor)
    {
        _computer.Processor = processor;
        return this;
    }

    public ComputerBuilder WithMemory(string memory)
    {
        _computer.Memory = memory;
        return this;
    }

    public ComputerBuilder WithStorage(string storage)
    {
        if (storage is not null)
        {
            _computer.Storage.Add(storage);
        }

        return this;
    }

    public ComputerBuilder WithMotherboard(string motherboard)
    {
        _computer.Motherboard = motherboard;
        return this;
    }

    public ComputerBuilder WithPowerSupply(string powerSupply)
    {
        _computer.PowerSupply = powerSupply;
        return this;
    }

    public ComputerBuilder WithCase(string computerCase)
    {
        _computer.Case = computerCase;
        return this;
    }

    public ComputerBuilder WithGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        return this;
    }

    public ComputerBuilder WithOperatingSystem(string operatingSystem)
    {
        _computer.OperatingSystem = operatingSystem;
        return this;
    }

    public Computer Build()
    {
        Computer builtComputer = _computer.DeepClone();

        ResetComputer();

        return builtComputer;
    }

    private void ResetComputer()
    {
        _computer = new Computer();
    }
}
