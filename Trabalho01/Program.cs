decimal l, c, total;
Console.Write("digite a base do terreno: ");
l = Convert.ToDecimal(Console.ReadLine());

Console.Write("digite a altura do comprimento: ");
c = Convert.ToDecimal(Console.ReadLine());

total = l * c;
Console.Write($"o total foi {total} metros quadrados ");
