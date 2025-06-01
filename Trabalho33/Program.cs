decimal maior, menor, altura, total;
Console.Write("Digite a base maior do trapezio: ");
maior = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a base menor do trapezio: ");
menor  = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a altura do trapezio: ");
altura = Convert.ToDecimal(Console.ReadLine());

total = ((maior + menor) * altura) / 2;

Console.Write($"A área total do trapezio é {total:F2}");