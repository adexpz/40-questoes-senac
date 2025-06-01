decimal cen1, cen5, cen10, cent25, cent50, total;

Console.Write("Digite a quantidade de moedas de 1 real: ");
cen1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quanidade de moedas de 0.05 centavos: ");
cen5 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quanidade de moedas de 0.25 centavos: ");
cent25 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quanidade de moedas de 0.50 centavos: ");
cent50 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quanidade de moedas de 0.10 centavos: ");
cen10 = Convert.ToDecimal(Console.ReadLine());

total = (cen1 * 1) + (cen5 * 0.05M) + (cent50 * 0.50m) + (cent25 * 0.25m) + (cen10 * 0.10m);

Console.Write ($"o total no cofrinho foi R${total}");