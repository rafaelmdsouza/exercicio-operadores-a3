double rafaelNota1, rafaelNota2, rafaelNota3, rafaelNota4;
rafaelNota1 = 9;
rafaelNota2 = 10;
rafaelNota3 = 9.5;
rafaelNota4 = 8;

var media = (rafaelNota1 + rafaelNota2 + rafaelNota3 + rafaelNota4) / 4;

if (media < 7)
    Console.WriteLine($"Sua média foi abaixo de 7, você não foi aprovado.");
else
    Console.WriteLine($"Você passou com {media}, parabéns! Você foi aprovado");



//EXERCÍCIO 10 
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Digite suas notas em ordem: ");

rafaelNota1 = Convert.ToDouble(Console.ReadLine());
rafaelNota2 = Convert.ToDouble(Console.ReadLine());
rafaelNota3 = Convert.ToDouble(Console.ReadLine());
rafaelNota4 = Convert.ToDouble(Console.ReadLine());

media = (rafaelNota1 + rafaelNota2 + rafaelNota3 + rafaelNota4) / 4;

if (media < 7)
    Console.WriteLine($"Sua média foi abaixo de 7, você não foi aprovado.");
else
    Console.WriteLine($"Você passou com {media}, parabéns! Você foi aprovado");