int frangos, pedirt = 2;

Console.Write("Digite a quantidade de frangos: ");
frangos = Convert.ToInt32(Console.ReadLine());

pedirt = frangos * 4;
int peesque = (int)(frangos * 3.5m);

Console.WriteLine($"para {frangos} frangos, a quantidade gasta de chip na perna direita e R${pedirt} é na perna esquerda sera gasto R${peesque}");                  
    