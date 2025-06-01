Console.Write("Digite um numero para fazer a tabuada: ");
int tab = Convert.ToInt32(Console.ReadLine());
for (int contador = 0; contador <= 10; contador++)
{
    int resultado = tab * contador;
    Console.WriteLine($"{tab} X {contador} = {resultado}");
}