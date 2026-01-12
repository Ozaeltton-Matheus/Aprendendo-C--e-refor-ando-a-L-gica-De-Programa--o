// Vetor de cores
String [] cores = {"Verde", "Amarelo", "Vermelho", "Azul", "Roxo"};

// Exibir cada cor usando o laço foreach
// Laço foreach

foreach (String cor in cores) // No parenteses começamos especificando qual é o tipo de dado do vetor nesse caso o vetor cores é do tipo String em cores eu referencio o vetor e cores é um objeto que vai receber as cores uma depois da outra
{
    Console.WriteLine(cor); // Aqui o laço foreach vai percorrer uma a uma as cores que estão presentes no vetor e o Console.WriteLine vai exibi-las.
}

// O foreach é mais simples de usar doque o for, p while e o do while ele é mais enxuto.
// Com o tempo descobrimos qual laço de repetição é ideal para cada aplicação que vamos desenvolver.
