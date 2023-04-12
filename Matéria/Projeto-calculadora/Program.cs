//1. definir operação
//2. informar o 1 numero
//3. informar o 2 numero
//4. processar os dados inseridos
//5. exibir resultados


//entrada

Console.WriteLine(@$"                                       
                                                            // ----------------------------------------------------
                                                            // | Programa calculadora                             |
                                                            // | Informe a operação matemática que deseja efetuar |
                                                            // | '+' para somar                                   |
                                                            // | '-' para subtrair                                |
                                                            // | '*' para multiplicar                             |
                                                            // | '/' para dividir                                 |
                                                            // ----------------------------------------------------
");



//recebe a operação escolhida
char operacao = char.Parse(Console.ReadLine());

//entrada do primeiro número
Console.WriteLine($"digite o seu primeiro número");
float numero1 = float.Parse(Console.ReadLine());

//entrada do segundo número
Console.WriteLine($"digite o seu segundo número");
float numero2 = float.Parse(Console.ReadLine());

float resultado = 0;

//processamento
switch (operacao)
{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da operação é igual à {resultado}");
        break;

    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"O resultado da operação é igual à {resultado}");
        break;

    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"O resultado da operação é igual à {resultado}");
        break;

    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"O resultado da operação é igual à {resultado}");
        break;

    default:
        Console.WriteLine($"A operação informada não é suportada pela nossa calculadora");
        break;
}