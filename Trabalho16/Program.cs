decimal  sanduiche, presunto = 0.50m, queijo = 0.50m, rodela = 0.100m;
Console.Write("Digite a quantidade de sanduiche que deseja fazer: ");
sanduiche = Convert.ToInt32(Console.ReadLine());

rodela =  (sanduiche * 0.100M) / 1000 ;
queijo =  (sanduiche * 0.50m) / 1000;
presunto = (sanduiche * 0.50m) / 1000;

Console.WriteLine($"Total rodela em kg: {rodela}\nTotal queijo em kg: {queijo}\nTotal presunto em kg: {presunto}");
