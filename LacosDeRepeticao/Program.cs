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
    string senhaIformada;
    string senhaCorreta = "9090abc@";

    do{
        Console.WriteLine($"Usuário, digite uma senha:");
        senhaIformada = Console.ReadLine();
    }while(senhaCorreta != senhaIformada);

    Console.WriteLine($"Acesso concedido!");
    

