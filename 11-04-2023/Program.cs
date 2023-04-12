// //criar um array de strings para armazenar 3 carros
// string[] carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Informe o nome do carro: ");    
//     carros[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Lista dos carros cadastrados: ");

// // for (var i = 0; i < 3; i++)
// // {
// //     Console.WriteLine($"Nome do carro: {carros[i]}");    
// // }

// foreach (var item in carros)
// {
//     Console.WriteLine(item);    
// }




// // entrada:
// int[] numeros = new int[5];
// // processamento:
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º número escolhido: ");    
//     numeros[i] = int.Parse(Console.ReadLine());
// }
// // saída:
// Console.WriteLine($"O dobro dos números é respectivamente: ");
// foreach (var dobro in numeros)
// {
//     Console.WriteLine(dobro*2);    
// }



// entrada:
string[] nome = new string[5];
int[] idade = new int[5];
//processamento:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a nome da {i + 1}º pessoa: ");    
    nome[i] = Console.ReadLine().ToLower();

    Console.WriteLine($"Informe a idade da {i + 1}º pessoa: ");    
    idade[i] = int.Parse(Console.ReadLine());
}

// saída:
Console.WriteLine($"Os nomes e as idades apresentadas foram: ");
for (var i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i + 1}º nome: {nome[i]}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{i + 1}º idade: {idade[i]} anos");
}