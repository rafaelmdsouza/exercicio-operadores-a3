double tempCelsius = 20;

var convertFahrenheit = (9 * tempCelsius + 160) / 5;

Console.WriteLine(convertFahrenheit);

var tempFahrenheit = convertFahrenheit;

var convertCelsius = (tempFahrenheit - 32) * 5 / 9;

Console.WriteLine(convertCelsius);

//EXERCICIO 10 
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Digite a temperatura em Celsius");

tempCelsius = Convert.ToDouble(Console.ReadLine());
convertFahrenheit = (9 * tempCelsius + 160) / 5;

Console.WriteLine($"A temperatura convertida de Celsius para Fahrenheit é de {convertFahrenheit} F");


Console.WriteLine("Digite a temperatura em Fahrenheit");

tempFahrenheit = Convert.ToDouble(Console.ReadLine());
convertCelsius = (tempFahrenheit - 32) * 5 / 9;

Console.WriteLine($"A temperatura convertida de Fahrenheit para Celsius é de {convertCelsius} ºC");
