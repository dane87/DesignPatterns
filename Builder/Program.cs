using Builder;

var computerBuilder = new ComputerBuilder();

Computer gamingComputer = computerBuilder
    .WithProcessor("Intel Core i7")
    .WithMemory("Corsair Vengeance 16GB")
    .WithStorage("1TB NVMe SSD")
    .WithMotherboard("ASUS ROG Strix Z390-E")
    .WithPowerSupply("Corsair RM750x")
    .WithCase("NZXT H510")
    .WithGraphicsCard("NVIDIA GeForce RTX 2080 Ti")
    .WithOperatingSystem("Windows 11")
    .Build();

Console.WriteLine("Gaming Computer built with the following components:");
Console.WriteLine($"Processor: {gamingComputer.Processor}"); // Intel Core i7
Console.WriteLine($"Memory: {gamingComputer.Memory}"); // Corsair Vengeance 16GB
Console.WriteLine($"Storage: {string.Join(", ", gamingComputer.Storage)}"); // 1TB NVMe SSD
Console.WriteLine($"Motherboard: {gamingComputer.Motherboard}"); // ASUS ROG Strix Z390-E
Console.WriteLine($"Power Supply: {gamingComputer.PowerSupply}"); // Corsair RM750x
Console.WriteLine($"Case: {gamingComputer.Case}"); // NZXT H510
Console.WriteLine($"Graphics Card: {gamingComputer.GraphicsCard}"); // NVIDIA GeForce RTX 2080 Ti
Console.WriteLine($"Operating System: {gamingComputer.OperatingSystem}"); // Windows 11

Console.WriteLine();

Computer homeServerComputer = computerBuilder
    .WithProcessor("Intel Core i9")
    .WithMemory("Corsair Vengeance 32GB")
    .WithStorage("2TB NVMe SSD")
    .WithStorage("10TB HDD")
    .WithStorage("10TB HDD")
    .WithMotherboard("ASUS ROG Strix Z390-E")
    .WithGraphicsCard("NVIDIA GeForce RTX 3080 Ti")
    .WithOperatingSystem("Windows 11")
    .Build();

Console.WriteLine("Home Server Computer built with the following components:");
Console.WriteLine($"Processor: {homeServerComputer.Processor}"); // Intel Core i9
Console.WriteLine($"Memory: {homeServerComputer.Memory}"); // Corsair Vengeance 32GB
Console.WriteLine($"Storage: {string.Join(", ", homeServerComputer.Storage)}"); // 2TB NVMe SSD, 10TB HDD, 10TB HDD
Console.WriteLine($"Motherboard: {homeServerComputer.Motherboard}"); // ASUS ROG Strix Z390-E
Console.WriteLine($"Power Supply: {homeServerComputer.PowerSupply}"); // 
Console.WriteLine($"Case: {homeServerComputer.Case}"); // 
Console.WriteLine($"Graphics Card: {homeServerComputer.GraphicsCard}"); // NVIDIA GeForce RTX 3080 Ti
Console.WriteLine($"Operating System: {homeServerComputer.OperatingSystem}"); // Windows 11

Console.WriteLine();

Computer workComputer = computerBuilder
    .WithProcessor("Intel Core i9")
    .WithMemory("Corsair Vengeance 32GB")
    .WithStorage("2TB NVMe SSD")
    .WithMotherboard("ASUS ROG Strix Z390-E")
    .WithGraphicsCard("NVIDIA GeForce RTX 3080 Ti")
    .WithOperatingSystem("Windows 11")
    .Build();

Console.WriteLine("Work Computer built with the following components:");
Console.WriteLine($"Processor: {workComputer.Processor}"); // Intel Core i9
Console.WriteLine($"Memory: {workComputer.Memory}"); // Corsair Vengeance 32GB
Console.WriteLine($"Storage: {string.Join(", ", workComputer.Storage)}"); // 2TB NVMe SSD
Console.WriteLine($"Motherboard: {workComputer.Motherboard}"); // ASUS ROG Strix Z390-E
Console.WriteLine($"Power Supply: {workComputer.PowerSupply}"); // 
Console.WriteLine($"Case: {workComputer.Case}"); // 
Console.WriteLine($"Graphics Card: {workComputer.GraphicsCard}"); // NVIDIA GeForce RTX 3080 Ti
Console.WriteLine($"Operating System: {workComputer.OperatingSystem}"); // Windows 11

Console.WriteLine();
