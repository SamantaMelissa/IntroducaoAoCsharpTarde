// See https://aka.ms/new-console-template for more information
//Console.WriteLine -> Escreve no nosso console
//Console.ReadLine -> Lê o dado do console, nesse caso: Escrito pelo usuário.
//Criar variável: tipododado nomedavariavel
Console.WriteLine("Olá, Lucas!");
Console.WriteLine("Você está bem?");

Console.WriteLine("Qual a sua comida favorita?");
string comida = Console.ReadLine();

Console.WriteLine($"Que legal, Lucas! Sua comida favorita é: {comida}");

Console.WriteLine("Lucas, escolha alguém para falar a comida favorita dela");
string nomePessoaNova = Console.ReadLine()!;

Console.WriteLine($"Seja bem vindo {nomePessoaNova}, qual sua comida favorita?");
string comidaNova = Console.ReadLine()!;

Console.WriteLine($"Que legal, {nomePessoaNova} ! Sua comida favorita é: {comidaNova}");

//int
//bool
//float
