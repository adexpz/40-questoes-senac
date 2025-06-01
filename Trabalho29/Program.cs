decimal produo, desconto, total;

Console.Write("Digite o preço do produto: ");
produo = Convert.ToDecimal(Console.ReadLine());

total = produo * 10 / 100;
total = produo - total;

Console.Write($"O total do produto com 10 % de desconto foi {total}");
