decimal predio, sombra, sombrapess, total;
Console.Write("Digite a altura do predio: ");
predio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a altura da sombra do predio: ");
sombra = Convert.ToDecimal(Console.ReadLine());

Console.Write("digite a altura da pessoa: ");
sombrapess = Convert.ToDecimal(Console.ReadLine());

total = (predio *  sombrapess) / sombra;
Console.WriteLine($"a altura do predio e {total} metros");