double milhas,km;

Console.Write("Valor em milhas:");
milhas = Convert.ToDouble(Console.ReadLine()!);


Console.Clear();
Console.WriteLine($"valor em milhas {milhas}");
Console.Write("Valor em km");
km = milhas * 1*1.609;
Console.WriteLine($"{km}");
