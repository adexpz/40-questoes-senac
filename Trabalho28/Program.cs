Console.Write("Digite a nota do teste de historia: ");
int mat = Convert.ToInt32(Console.ReadLine());
mat = mat * 2;


Console.Write("Digite a nota no teste de portugues: ");
int port = Convert.ToInt32(Console.ReadLine());
port = port * 3;


decimal total = mat + port;


total = total / 5;

Console.Write($"a media ponderada e {total}");

