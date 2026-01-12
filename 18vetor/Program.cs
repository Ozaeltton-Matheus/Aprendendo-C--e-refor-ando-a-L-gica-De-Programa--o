// Vetor (array)
// O vetor é uma estrutura onde podemos armazenar muitas informações, como se fosse um pequeno banco de dados

// Vetor de nomes
String [] nomes = {"Matheus", "Welson", "Denys", "Vivian"}; // Os nomes ficam dentro das chaves

// Exibir os nomes
Console.WriteLine($"{nomes[0]} e {nomes[3]}"); // Se não colocar mais nada o Console.WriteLine exibe System.String[] é necessário informar qual elemento quer exibir pela posição no caso ficaria Console.WriteLine(nomes[0]); para exibir o primeiro nome que nesse caso é Matheus
//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);
//Console.WriteLine(nomes[2]);
//Console.WriteLine(nomes[3]);

// Laço para (for)
for(int indice = 0; indice <4; indice++)
{
    Console.WriteLine(nomes[indice]);
    while(nomes[indice] == "Vivian")
{
    Console.WriteLine($"Eu gosto de você {nomes[3]}! ");
    break;
}
}

