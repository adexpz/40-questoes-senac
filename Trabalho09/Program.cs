int camisetasp, camisetasm, camisetasg;

Console.Write("Digite a quantidade de camisetas (P) vendidas: ");
camisetasp = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de camisetas (M) vendidas: ");
camisetasm = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de camisetas (G) vendidas: ");
camisetasg = Convert.ToInt32(Console.ReadLine());

int soma = (camisetasp * 10) + (camisetasm * 12) + (camisetasg * 15);

Console.WriteLine($"o total arrecadado foi R${soma} ");
