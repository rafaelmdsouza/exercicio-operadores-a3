double value1 = 2;
double value2 = 15;

var divisao = value1 / value2;
var modularizacao = value2 % value1;

Console.WriteLine(divisao);
Console.WriteLine(modularizacao);

//EXERCICIO 10 
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Digite os dois valores: ");

value1 = Convert.ToInt32(Console.ReadLine());
value2 = Convert.ToInt32(Console.ReadLine());

divisao = value1 / value2;
modularizacao = value2 % value1;


if (value2 == 0)
    Console.WriteLine("Você não pode dividir por 0");
else
    Console.WriteLine(divisao);
    Console.WriteLine(modularizacao);