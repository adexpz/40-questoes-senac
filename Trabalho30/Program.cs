decimal salario, vendas, comissao;
Console.Write("digite seu salario: ");
salario = Convert.ToDecimal(Console.ReadLine());

Console.Write("digite a quantidade de vendas: ");
vendas = Convert.ToDecimal(Console.ReadLine());

comissao = vendas * 0.4m;
salario = salario + comissao;

Console.Write($"o salario total ficou R${salario}");
