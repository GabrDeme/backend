// bool sol = true;
// bool folga= false;

// if (sol && folga)
// {
//     Console.WriteLine($"Vou para a praia!");
// }
// else
// {
//     Console.WriteLine($"Vou é trabalhar!");
// }

//                                                         -------------------------
//                                                         |Operador de condicional|
//                                                         |       ternário        |
//                                                         -------------------------

// int x = 2;
// int y = 3;

// if (x == y)
// {
//     Console.WriteLine($"São iguais");
// }
// else
// {
//     Console.WriteLine($"São diferentes");
// }

// string eIgual = (x == y) ? "São iguais" : "São diferentes"
// Console.WriteLine($"eIgual");



//                                                         -------------------------
//                                                         |Operador de condicional|
//                                                         |       encadeado       |
//                                                         -------------------------


// maior ou igual a 18 : pode entrar na festa
// maior ou igual a 16 menor de 18 : pode entrar com responsável
//menor do que 16 : não pode entrar

int idade = 16;

if(idade >=18)
{
    Console.WriteLine($"Pode entrar na festa");
}
else if (idade >= 16 && idade <18)
{
    Console.WriteLine($"Somente com responsável");
}
else
{
    Console.WriteLine($"Não pode entrar");
}