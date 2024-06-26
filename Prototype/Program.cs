using Prototype;

Computer officeComputer = new();
officeComputer.Storage.Add("SSD");
officeComputer.OperatingSystem = new Prototype.OperatingSystem { Name = "Windows", Version = "11" };

Computer homeComputer = officeComputer.Clone();
officeComputer.OperatingSystem.Name = "Linux";
homeComputer.Storage.Add("HDD");

Console.WriteLine(officeComputer.Storage[1]); // HDD
Console.WriteLine(homeComputer.Storage[1]); // HDD
Console.WriteLine(officeComputer.OperatingSystem!.Name); // Linux
Console.WriteLine(homeComputer.OperatingSystem!.Name); // Linux

Console.WriteLine();

Computer gamingComputer = new();
gamingComputer.Storage.Add("SSD");
gamingComputer.OperatingSystem = new Prototype.OperatingSystem { Name = "Windows", Version = "11" };

Computer onlyFansComputer = gamingComputer.DeepClone();
onlyFansComputer.OperatingSystem!.Name = "Linux";
onlyFansComputer.Storage.Add("HDD");

Console.WriteLine(gamingComputer.Storage.Count); // 1
Console.WriteLine(onlyFansComputer.Storage.Count); // 2
Console.WriteLine(gamingComputer.OperatingSystem!.Name); // Linux
Console.WriteLine(onlyFansComputer.OperatingSystem!.Name); // Linux

Console.WriteLine();
