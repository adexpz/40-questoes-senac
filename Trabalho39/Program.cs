decimal salario, c1 = 200, c2 = 120, multa, multa2, total, resto;

Console.Write("Digite seu salario: ");
salario = Convert.ToDecimal(Console.ReadLine());

multa = c1 * 2 / 100;
multa2 = c2 * 2 / 100;

total = c1 + c2;
resto = salario - total;
Console.Write($"o restante do salario com as mutas (multa = 200. multa2 = 120), o que sobrara do salario e {resto}");