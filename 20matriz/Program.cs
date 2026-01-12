// Matrizes (ou arrays multidimencionais)
// A diferença de um vetor (array) para uma matriz (arrey multidimencional) é que o vetor (arrey) tem uma unica coluna e varias linhas já a matriz (arrey multidimencional) tem varias colunas e varias linhas.

// Matriz

String [,] dados = // // A virgula serve para indicar que essa estrutura vai trabalhar com duas colunas
// As informações são acessadas por colunas a primeira coluna é a do indice 0 e a segunda coluna é a do indice 1
{
    {"Matheus", "Cerro Corá"},
    {"Welson", "Currais Novos"},
    {"Denys", "Parnamirim"},
    {"Vivian", "Cerro Corá"},
};  

// Exibir dados
Console.WriteLine(dados[0, 1]); // Para exibir os nomes é preciso indicar o indice que indica a posição da linha e depois é preciso indicar o indice que indica a posição da coluna.

foreach(string dado in dados)
{
    Console.WriteLine(dado);
}

