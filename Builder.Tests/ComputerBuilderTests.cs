using Builder;

namespace ComputerBuilderTests;

public class WithProcessor
{
    [TestCase("Intel i9")]
    [TestCase(null)]
    public void ShouldSetComputerProcesser(string processor)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithProcessor(processor).Build();

        Assert.That(computer.Processor, Is.EqualTo(processor));
    }
}

public class WithMemory
{
    [TestCase("Corsair Vengeance 16GB")]
    [TestCase(null)]
    public void ShouldSetComputerMemory(string memory)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithMemory(memory).Build();

        Assert.That(computer.Memory, Is.EqualTo(memory));
    }
}

public class WithStorage
{
    [Test]
    public void ShouldSetComputerStorage()
    {
        var computerBuilder = new ComputerBuilder();
        var storage = "1TB NVMe SSD";

        var computer = computerBuilder.WithStorage(storage).Build();

        Assert.That(computer.Storage, Contains.Item(storage));
    }

    [Test]
    public void ShouldNotAddNullComputerStorage()
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithStorage(null!).Build();

        Assert.That(computer.Storage, Has.Count.EqualTo(0));
    }
}

public class WithMotherboard
{
    [TestCase("ASUS ROG Strix Z390-E")]
    [TestCase(null)]
    public void ShouldSetComputerMotherboard(string motherboard)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithMotherboard(motherboard).Build();

        Assert.That(computer.Motherboard, Is.EqualTo(motherboard));
    }
}

public class WithPowerSupply
{
    [TestCase("Corsair RM750x")]
    [TestCase(null)]
    public void ShouldSetComputerPowerSupply(string powerSupply)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithPowerSupply(powerSupply).Build();

        Assert.That(computer.PowerSupply, Is.EqualTo(powerSupply));
    }
}

public class WithCase
{
    [TestCase("Some Case")]
    [TestCase(null)]
    public void ShouldSetComputerCase(string pcCase)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithCase(pcCase).Build();

        Assert.That(computer.Case, Is.EqualTo(pcCase));
    }
}

public class WithGraphicsCard
{
    [TestCase("NVIDIA GeForce RTX 2080 Ti")]
    [TestCase(null)]
    public void ShouldSetComputerGraphicsCard(string graphicsCard)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithGraphicsCard(graphicsCard).Build();

        Assert.That(computer.GraphicsCard, Is.EqualTo(graphicsCard));
    }
}

public class WithOperatingSystem
{
    [TestCase("Windows 11")]
    [TestCase(null)]
    public void ShouldSetComputerOperatingSystem(string operatingSystem)
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.WithOperatingSystem(operatingSystem).Build();

        Assert.That(computer.OperatingSystem, Is.EqualTo(operatingSystem));
    }
}

public class Build
{
    [Test]
    public void ShouldReturnBuiltComputerWithNullValuesWhenNoPropertiesAreSet()
    {
        var computerBuilder = new ComputerBuilder();

        var computer = computerBuilder.Build();

        Assert.That(computer, Is.Not.Null);
    }

    [Test]
    public void ShouldReturnBuiltComputerWithSetProperties()
    {
        var computerBuilder = new ComputerBuilder();

        var expectedProcesser = "i7";
        var expectedGraphicsCard = "2080";

        var computer = computerBuilder
            .WithProcessor(expectedProcesser)
            .WithGraphicsCard(expectedGraphicsCard)
            .Build();

        Assert.Multiple(() =>
        {
            Assert.That(computer.Processor, Is.EqualTo(expectedProcesser));
            Assert.That(computer.GraphicsCard, Is.EqualTo(expectedGraphicsCard));
        });
    }
}
