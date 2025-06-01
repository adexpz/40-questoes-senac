decimal raio, altura, volume, pi = 3.14m, litros;
Console.Write("Digite o raio da caixa em metros: ");
raio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a altura da caixa em metros: ");
altura = Convert.ToDecimal(Console.ReadLine());

volume = pi * raio * raio * altura;
litros = volume * 1000;
Console.Write($"O volume da caixa de água é {volume:F2} totalizando {litros:F2} litros de água");
