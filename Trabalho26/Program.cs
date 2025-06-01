int num1, total = 1;
for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o numero: ");
    num1= Convert.ToInt32(Console.ReadLine());
    total *= num1;

    
}
Console.Write($"o total mutiplicado dos numeros foi {total}");



