int dezena, unidade, centena;
Console.Write("Digite um numero de (100 ate 1000): ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 100 && numero <= 1000)
{
    centena = numero / 100;
    dezena  = (numero % 100) / 10;
    unidade = numero % 10;

    Console.Write($" Centena = {centena}\n Dezenas = {dezena}\n Unidades = {unidade}");
}
else
{
    Console.Write("Digite um numero valido!!!!!!");
}
