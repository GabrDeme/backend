// variáveis

int anoNascimento ;
int idade;
int idadeEmSemanas;
int anoAtual = DateTime.Now.Year;

Console.WriteLine($"Informe o ano do nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
idadeEmSemanas = (idade * 52);

Console.WriteLine($"A idade em anos é {idade} ano(s) e a idade em semanas é igual a {idadeEmSemanas}");