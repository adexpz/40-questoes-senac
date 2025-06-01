using System.Numerics;

int pontx1, pontx2, ponty1, ponty2;
Console.Write("digite o valor de x: ");
pontx1 = Convert.ToInt32(Console.ReadLine());

Console.Write("digite o segundo valor de x: ");
pontx2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de y: ");
ponty1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo valor de y: ");
ponty2 = Convert.ToInt32(Console.ReadLine());

decimal x = (pontx1 - pontx2) * (pontx1 - pontx2);
decimal y = (ponty1 - ponty2) * (ponty1 - ponty2);

decimal total = x + y;

decimal raiz = 0;

for (decimal i = 0; i * i <= total; i += 0.01m)
{
    raiz = i;
}
Console.WriteLine(raiz);



