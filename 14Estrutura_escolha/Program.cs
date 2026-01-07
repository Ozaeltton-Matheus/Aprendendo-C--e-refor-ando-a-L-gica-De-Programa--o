// Estrutura de escolha
// Possibilita um código mais limpo

// Variável
//string linguagem = "CSS";

// Variável com Console.ReadLine()
Console.WriteLine("ESCOLHA A LINGUAGEM PARA SABER MAIS SOBRE ELA:");
string ?linguagem = Console.ReadLine();
// Estrutura de escolha

// Switch case

// A palavra reservada switch serve para trocar a palavra que está na variável linguagem pelo valor que o usuário digitou no Console.ReadLine()

// switch (linguagem)
// {
//     case "HTML" : // Aqui é usado o case, que em português é caso. Então seria: caso a linguagem seja tal, exiba o texto tal com Console.WriteLine()
//     Console.WriteLine("Linguagem de Marcação de Hiper Texto.");
//     break; // Todo case tem que ter um break para ser o fim do caso

//     case "CSS" :
//     Console.WriteLine("Folhas de estilo em cascata\nÉ um mecanismo para adicionar estilos á uma página web.");
//     break;

//     case "C#" :
//     Console.WriteLine("Linguagem de programação Orientada a Objetos.");
//     break;

//     default: // Caso nenhum dos casos sejá verdadeiro (não existir na variável linguagem) conseguimos dar um retorno para o usuário.
//     Console.WriteLine("Linguagem desconhecida.");
//     break;
// }


// Expressão switch
string retorno = linguagem switch
{
    "HTML" => "Linguagem de Marcação de Hiper Texto",
    "CSS" => "Folhas de estilo em cascata\nÉ um mecanismo para adicionar estilos a uma página web.",
    "C#" => "Linguagem de programação Orientada a Objetos.",
    _ => "Linguagem desconhecida."
};

Console.WriteLine(retorno);