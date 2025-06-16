int pontx1, pontx2, ponty1, ponty2;

Console.Write("Digite o valor de x1: ");
pontx1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de x2: ");
pontx2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de y1: ");
ponty1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de y2: ");
ponty2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Pow(pontx2 - pontx1, 2);
double y = Math.Pow(ponty2 - ponty1, 2);

double distancia = Math.Sqrt(x + y);

Console.WriteLine($"Distância entre os pontos: {distancia:F2}");

