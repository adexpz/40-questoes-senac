decimal celsius, fahrenheit;

Console.Write("Digite a quantos  graus celsio para converte em fahrenheit: ");
celsius = Convert.ToDecimal(Console.ReadLine());

fahrenheit = celsius * 1.8M + 32;

Console.WriteLine($"{celsius}°C em fahrenheit e exatamente {fahrenheit} °F");
