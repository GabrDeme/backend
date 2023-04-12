// switch(expresion)
// {
//     case x:
//     //bloco de código
//     break;

//     case x:
//     //bloco de código
//     break;

//     default:
//     //bloco de código
//     break;
// }


Console.WriteLine($"Indorme o número correspondente ao dia da semana:");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"HOJE É DOMINGO!");
        break;
    case 2:
        Console.WriteLine($"HOJE É SEGUNDA!");
        break;
    case 3:
        Console.WriteLine($"HOJE É TERÇA!");
        break;
    case 4:
        Console.WriteLine($"HOJE É QUARTA!");
        break;
    case 5:
        Console.WriteLine($"HOJE É QUINTA!");
        break;
    case 6:
        Console.WriteLine($"HOJE É SEXTA!");
        break;
    case 7:
        Console.WriteLine($"HOJE É SÁBADO!");
        break;

    default:
        Console.WriteLine($"O dia informado nçao corresponde com nenhum dia da semana.");

        break;
}
