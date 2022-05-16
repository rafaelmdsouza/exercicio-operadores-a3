var euro = 750D;

var cotacaoReal = euro * 5.29;

Console.WriteLine(cotacaoReal);

//EXERCICIO 10 
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Bem vindo ao conversor de euro para real!");
Console.WriteLine("Digite o valor em euro que queira converter.");
euro = Convert.ToDouble(Console.ReadLine());

cotacaoReal = euro * 5.29;

Console.WriteLine($"O valor retornado é de R$ {cotacaoReal}");
