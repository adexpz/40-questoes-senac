decimal cocalata = 0.350m, cocagaram = 0.600m, garag = 2, cocalata1, cocagaram1, cocag1;

Console.Write("Digite a quantidade de cocalata 350 ML comprada: ");
cocalata1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("digite a quantidade de coca de 600 ml comprado: ");
cocagaram1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade de coca 2 litros comprada: ");
cocag1 = Convert.ToDecimal(Console.ReadLine());

decimal totalMl = (cocalata1 * cocalata + cocagaram1 * cocagaram + cocag1 * garag) * 1000;
decimal totallitros = totalMl / 1000;

Console.WriteLine($"Temos {totallitros:F3} litros de refrigerante.");
