int cavalos, total;
Console.Write("Digite a quantidade de cavalos: ");
cavalos = Convert.ToInt32(Console.ReadLine());
if (cavalos == 0)
{
    Console.WriteLine("quantidade invalida");
    return;

}
total = cavalos * 4;

Console.WriteLine($"o total de ferraduras para equipa {cavalos} cavalo são {total} ferraduras");
