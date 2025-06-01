Console.Write("Digite o salario do funcionario: ");
int salariobruto = Convert.ToInt32(Console.ReadLine());

int somar  = salariobruto * 15 / 100;
int aumento = somar + salariobruto;

int imposto = aumento * 8 / 100;
int salarioliqui =   aumento - imposto;


Console.Write($" o salario bruto e R${salariobruto} o salario com o aumento e R${aumento} o salario total  e R${salarioliqui}");