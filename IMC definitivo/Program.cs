Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
______________
|Program para|
|C͟a͟l͟c͟u͟l͟a͟r͟ I͟M͟C͟|


");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente: ");
String nome = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-vindo ao nosso sistema {nome}");
Console.ResetColor()

Console.WriteLine($"Informe o peso do paciente: ");
float peso =  float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine())

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"O paciente {nome} tem imc igual à: {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();