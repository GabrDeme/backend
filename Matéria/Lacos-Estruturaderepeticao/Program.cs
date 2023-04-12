// bool = idadeCerta = false

// while (idadeCerta == false)
// {
//     Console.WriteLine($"Qual a idade do Péricles");
//     int idade = int.Parse(Console.ReadLine()2;

//     if (idade ==53)
//     {
//         idadeCerta = true
//     }
// }



//Um programa que receba o nome do usuário e a sanha 
//A senha deve ter 6 caracteres
//Validar a senha 
//Enquanto a senha não estiver com a regra pedida, preciso que o programa não se encerre e que solicite que seja digitado uma senha no padrão requerido
//Caso a senha informada esteja com 6 caracteres, exiba uma mensagem de ok

Console.WriteLine($"Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a sua senha (tem que ter 6 caracteres)");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Digite uma senha no padrão requerido (com 6 caracteres)");
    senha = Console.ReadLine();
}
Console.WriteLine($"Usuário e senha recebidos com sucesso");
