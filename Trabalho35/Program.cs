decimal menor, maior, total;

Console.Write("Digite a diagonal maior do losangolo: ");
maior = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a diagonal menor do losangolo: ");
menor = Convert.ToDecimal(Console.ReadLine());

total = (maior * menor) / 2;

Console.Write($"o total do losangolo e {total}");   

