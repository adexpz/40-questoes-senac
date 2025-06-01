decimal pesoini, pesoeng, pesoema;

Console.Write("Digite seu pesso: ");
pesoini = Convert.ToDecimal(Console.ReadLine());

pesoeng = pesoini * 1.5m;
pesoema = pesoini + (pesoini *  15 / 100);

Console.Write($"O peso inicial {pesoini} KG , pesso se engorda 15 % {pesoeng}KG, pesso se diminuir 15 % {pesoema} KG. ");
