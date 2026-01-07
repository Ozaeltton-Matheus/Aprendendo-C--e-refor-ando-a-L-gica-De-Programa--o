Console.WriteLine("Digite qual foi a sua primeira nota: ");
// Variável para armazenar a primeira nota
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite qual foi a sua segunda nota: ");
// Variável para armazenar a segunda nota
double nota2 = Convert.ToDouble(Console.ReadLine());

// Variável da média do aluno
double media = (nota1 + nota2) /2;

// Opérador ternário
// Posso atribuir o retorno dp ternário em uma nova variável ou simplesmente exibir em um Console.WriteLine("");
// Exemplo com Console.WriteLine("");

// A média é maior ou igual a 6? se for exiba "Aprovado(a) e se não for exiba "Reprovado(a)"
// Console.WriteLine(media >=6 ? "Aprovado(a)" : "Reprovado(a)");

// Testando com a atribuição em uma variável
// double situacao = media >=6 ? "Reprovado(a)" : "Aprovado(a)";

// Deu errado com uma variável
// O erro foi porque eu atribuí a variável do tipo double ao invés de string kkk

string situacao = media >=6 ? "Reprovado(a)" : "Aprovado(a)";
Console.WriteLine(situacao);
// Agora funcionou