// static void Saudacao()
// {
//     Console.WriteLine($"Informe o nome da pessoa: ");
//     string nome = Console.ReadLine();

//     Console.WriteLine($"Informe o sobrenome da pessoa: ");
//     string sobrenome = Console.ReadLine();

//     Console.WriteLine($"Bom dia {nome}  {sobrenome}");

char operacao;

Console.WriteLine($"Escolha uma operação: ");
operacao = char.Parse(Console.ReadLine().ToLower());

switch (operacao)
{
    case '+':
        static float Somar(float n1, float n2)
        {
            return (n1 + n2);
        }

        Console.WriteLine($"Informe o primeiro número: ");
        float primeiroNumero = float.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o segundo número: ");
        float segundoNumero = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é: {Somar(primeiroNumero, segundoNumero)}");
        break;
    case '-':
        static float Subtrair(float n1, float n2)
        {
            return (n1 - n2);
        }

        Console.WriteLine($"Informe o primeiro número: ");
        float primeiroNumero1 = float.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o segundo número: ");
        float segundoNumero1 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma de {primeiroNumero1} - {segundoNumero1} é: {Subtrair(primeiroNumero1, segundoNumero1)}");
        break;
    case 'x':
        static float Multiplicar(float n1, float n2)
        {
            return (n1 * n2);
        }

        Console.WriteLine($"Informe o primeiro número: ");
        float primeiroNumero2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o segundo número: ");
        float segundoNumero2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma de {primeiroNumero2} * {segundoNumero2} é: {Multiplicar(primeiroNumero2, segundoNumero2)}");
        break;
    case '/':
        static float Dividir(float n1, float n2)
        {
            return (n1 / n2);
        }

        Console.WriteLine($"Informe o primeiro número: ");
        float primeiroNumero3 = float.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o segundo número: ");
        float segundoNumero3 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma de {primeiroNumero3} / {segundoNumero3} é: {Dividir(primeiroNumero3, segundoNumero3)}");
        break;
    default:
        Console.WriteLine($"Essa variável não existe, portanto insira novamente uma das quatro operações");
        operacao = char.Parse(Console.ReadLine().ToLower());
        break;
}


