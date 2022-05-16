double height = 1.82;

var idealWeight = (72.7 * height) - 58;

Console.WriteLine(idealWeight);

//EXERCICIO 10 
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Digite a sua altura");

height = Convert.ToDouble(Console.ReadLine());
idealWeight = (72.7 * height) - 58;

Console.WriteLine($"Seu peso ideal é {idealWeight}");