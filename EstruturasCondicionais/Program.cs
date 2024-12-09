//Estrutura Condicional - IF Simples
    //Exemplo: Caso esteja chovendo, avise o usuário para levar o guarda-chuva

    bool chovendo = true;

    if(chovendo == true){
        Console.WriteLine($"Leve o guarda-chuva!");
    }


//Estrutura Condicional - IF Composto
    //Exemplo: Quero saber se o usuário é menor ou maior de idade.

    int idade = 18;

    if(idade >= 18){
        Console.WriteLine($"O usuário é maior de idade");
    }else{
        Console.WriteLine($"O usuário é menor de idade");
    }

//Estrutura Condicional - IF Encadeado
    //Exemplo: Quero saber se o usuário é menor ou maior de idade. Caso o usuário informe algum valor negativo, imprima uma mensagem de erro.

    int idade = 5;

    if(idade >= 18){
        Console.WriteLine($"O usuário é maior de idade");
    }else if(idade > 0 && idade < 18){
        Console.WriteLine($"O usuário é menor de idade");
    }else{
        Console.WriteLine($"Erro! Idade inválida");  
    }