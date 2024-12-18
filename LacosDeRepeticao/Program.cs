//Estrutura de repetição 
//While -> Enquanto a condição for VERDADEIRA, a repetição irá acontecer

// int contador = 1;

// while(contador <= 1000){
//     Console.WriteLine($"O número atual é: {contador}");
//     // contador = contador + 1;
//     contador++;

// }

//do while -> há a execução e depois há a verificação da condição
    //O usuario ira informar a senha do sistema ATÉ que a senha seja correta
    // string senhaIformada;
    // string senhaCorreta = "9090abc@";

    // do{
    //     Console.WriteLine($"Usuário, digite uma senha:");
    //     senhaIformada = Console.ReadLine();
    // }while(senhaCorreta != senhaIformada);

    // Console.WriteLine($"Acesso concedido!");
    
//----------------------------------------------------------------------------------------
//for e foreach

//For -> para
//Ele é usado quando sabemos EXATAMENTE a quantidade de vezes que algo deve se repetir

//for(inicialização; condição; incremento/decremento){}

//Exemplo 01: O piloto Kauã está dentro de uma corrida e precisa dar 10 voltas na pista. A cada corrida, precisa aparecer no meu sistema a mensagem: "Corrida completada!"
// using System.Threading;

// for(int volta = 1; volta <=10; volta++){

//     Console.WriteLine($"Kaua, vc fez o pit-stop?");
//     string resposta = Console.ReadLine();
    
//     if(resposta == "sim"){
//         Thread.Sleep(4000);
//     }
//     Console.WriteLine($"Corrida completada!");
// }

//Foreach -> para cada
//Usado quando queremos percorrer/ler/trabalhar com coleções de dados -> lista, array, dicionário
string[] nomes = {"Samanta", "Kaua", "Lucas", "Júlia", "Yasha", "Maria", "Anna", "Sayra"};

// Console.WriteLine($"A Samanta vai ganhar na mega");
// Console.WriteLine($"O Kaua vai ganhar na mega");
// Console.WriteLine($"O Lucas vai ganhar na mega");
// Console.WriteLine($"A Julia vai ganhar na mega");

foreach(string nomeIndividual in nomes){
    Console.WriteLine($"O(a) {nomeIndividual} vai ganhar na mega");
    
}