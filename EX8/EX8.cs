int valueA = 10;
int valueB = 50;

int subtracao = valueA - valueB;

Console.WriteLine(subtracao);

if (subtracao < 0)
    Console.WriteLine("TOTAL NEGATIVO");
else
    Console.WriteLine("TOTAL POSITIVO");

//EXERCICIO 10 
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Digite os dois valores a serem subtraidos:");

valueA = Convert.ToInt32(Console.ReadLine());
valueB = Convert.ToInt32(Console.ReadLine());

subtracao = valueA - valueB;

Console.WriteLine(subtracao);

if (subtracao < 0)
    Console.WriteLine("TOTAL NEGATIVO");
else
    Console.WriteLine("TOTAL POSITIVO");
