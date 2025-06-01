decimal pesoini, total;
Console.Write("digite seu pesso em KG para transforma em Gramas : ");
pesoini = Convert.ToDecimal(Console.ReadLine());

total = pesoini * 1000;

Console.WriteLine($"O seu pesso convertidos para gramas é {total} ");
