// Crie um programa para calcular o IMC de uma pessoa

// Algoritmo
// entrada: nome, idade;
// processamento: peso dividido pela altura ao quadrado


// //processamento
// float imc = peso / (altura * altura);

// //saída
// Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2)  );


// Console.WriteLine($"Você tem {idade} anos);



// MESES////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine($"Digite o seu nome: ");
String nome = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-vindo ao nosso sistema {nome}");
Console.ResetColor();

Console.WriteLine($"Informe a sua idade: ");
float idade =  float.Parse(Console.ReadLine());

float meses = ( idade * 12);

Console.WriteLine($"Você tem {meses} meses de idade");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();

// DIAS////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine($"Digite o seu nome: ");
String nome = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-vindo ao nosso sistema {nome}");
Console.ResetColor();

Console.WriteLine($"Informe a sua idade: ");
float idade =  float.Parse(Console.ReadLine());

float dias = (idade * 365);

Console.WriteLine($"Você tem {dias} dias de vida");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();


