using System.Globalization;

Console.Write("digite o numero do més que estamos: ");
int mes = Convert.ToInt32(Console.ReadLine());
if (mes == 0)
{
    Console.WriteLine("Digite um més valido");
    return;
}
mes = mes * 30;

Console.Write("digite o dia que estamos: ");
int dia = Convert.ToInt32(Console.ReadLine());
if (dia == 0)
{
    Console.WriteLine("Digite um dia valido");
    return;
}
dia = dia + mes;

Console.WriteLine($"ja se passaram {dia} Dias desdo começo do ano");
    


