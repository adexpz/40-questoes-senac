decimal salariomin, salariofunc, total;

Console.Write("Digite o valor do salario minimo: ");
salariomin = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor do salario do funcionario: ");
salariofunc = Convert.ToDecimal(Console.ReadLine());

total = salariofunc / salariomin;

Console.Write($"O Funcionario receber {total} salario mínimo");

