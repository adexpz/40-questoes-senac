decimal num1, num2, total;

Console.Write($"Digite O primeiro numero: ");
num1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite O segundo numero: ");
num2 = Convert.ToDecimal(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("divisão por zero não é permitida");
}
else
{
    total = num1 / num2;
    Console.WriteLine($"Resultado da divisão: {total}");
}