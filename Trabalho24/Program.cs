decimal agua = 0.8m, maracuja = 0.2m;
decimal sucos, qdAgua, qdMaracuja;

Console.Write("Digite a quantidade de sucos que você quer fazer: ");
sucos = Convert.ToDecimal(Console.ReadLine());

qdAgua = sucos * agua;
qdMaracuja = sucos * maracuja;

Console.WriteLine($"A quantidade de água é {qdAgua:F2} L e de maracujá é {qdMaracuja:F2} L");