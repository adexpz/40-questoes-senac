using System.IO.Pipes;

int dias, anos, meses;
Console.Write("Digite a quantidade de dias que estamos sem acidentes ");
dias = Convert.ToInt32(Console.ReadLine());

anos = dias / 360;           
int DepoisAnos = dias % 360;  

meses = DepoisAnos / 30;     
dias = DepoisAnos % 30;

Console.WriteLine($"se passaram {anos} anos é  {meses} mês é  {dias} Dias ");