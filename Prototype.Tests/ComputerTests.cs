using Prototype;

namespace ComputerTests;

public class Clone
{
    // Should keep references to arrays
    [Test]
    public void ShouldExpectToShareArrayWithClone()
    {
        var officeComputer = new Computer();
        officeComputer.Storage.Add("SSD");

        var homeComputer = officeComputer.Clone();
        homeComputer.Storage.Add("HDD");

        Assert.That(officeComputer.Storage[1], Is.EqualTo("HDD"));
        Assert.That(homeComputer.Storage[1], Is.EqualTo("HDD"));
    }

    // Should keep references to objects
    [Test]
    public void ShouldExpectToShareObjectWithClone()
    {
        var officeComputer = new Computer
        {
            OperatingSystem = new Prototype.OperatingSystem { Name = "Windows", Version = "11" }
        };

        var homeComputer = officeComputer.Clone();
        homeComputer.OperatingSystem!.Name = "Linux";

        Assert.Multiple(() =>
        {
            Assert.That(officeComputer.OperatingSystem.Name, Is.EqualTo("Linux"));
            Assert.That(homeComputer.OperatingSystem.Name, Is.EqualTo("Linux"));
        });
    }

    // Should not keep references to primitive types
    [Test]
    public void ShouldCreateAShallowCopyOfComputerWithoutPrimitiveReferences()
    {
        var officeComputer = new Computer
        {
            Processor = "Intel"
        };

        var homeComputer = officeComputer.Clone();
        homeComputer.Processor = "AMD";

        Assert.Multiple(() =>
        {
            Assert.That(officeComputer.Processor, Is.EqualTo("Intel"));
            Assert.That(homeComputer.Processor, Is.EqualTo("AMD"));
        });
    }
}

public class DeepClone
{
    [Test]
    public void ShouldNotShareArrayWithClone()
    {
        var gamingComputer = new Computer();
        gamingComputer.Storage.Add("SSD");

        var onlyFansComputer = gamingComputer.DeepClone();
        onlyFansComputer.Storage.Add("HDD");

        Assert.Multiple(() =>
        {
            Assert.That(gamingComputer.Storage, Has.Count.EqualTo(1));
            Assert.That(onlyFansComputer.Storage, Has.Count.EqualTo(2));
        });
    }

    [Test]
    public void ShouldNotShareObjectWithClone()
    {
        var officeComputer = new Computer
        {
            OperatingSystem = new Prototype.OperatingSystem { Name = "Windows", Version = "11" }
        };

        var homeComputer = officeComputer.DeepClone();
        homeComputer.OperatingSystem!.Name = "Linux";

        Assert.Multiple(() =>
        {
            Assert.That(officeComputer.OperatingSystem.Name, Is.EqualTo("Windows"));
            Assert.That(homeComputer.OperatingSystem.Name, Is.EqualTo("Linux"));
        });
    }

    [Test]
    public void ShouldCreateADeepCopyOfComputerIncludingArraysAndObjects()
    {
        var officeComputer = new Computer
        {
            Processor = "Intel",
            Storage = { "SSD" },
            OperatingSystem = new Prototype.OperatingSystem { Name = "Windows", Version = "11" }
        };

        var homeComputer = officeComputer.DeepClone();
        homeComputer.Processor = "AMD";
        homeComputer.Storage.Add("HDD");
        homeComputer.OperatingSystem!.Name = "Linux";

        Assert.Multiple(() =>
        {
            Assert.That(officeComputer.Processor, Is.EqualTo("Intel"));
            Assert.That(officeComputer.Storage, Has.Count.EqualTo(1));
            Assert.That(officeComputer.OperatingSystem.Name, Is.EqualTo("Windows"));
            Assert.That(homeComputer.Processor, Is.EqualTo("AMD"));
            Assert.That(homeComputer.Storage, Has.Count.EqualTo(2));
            Assert.That(homeComputer.OperatingSystem.Name, Is.EqualTo("Linux"));
        });
    }
}
