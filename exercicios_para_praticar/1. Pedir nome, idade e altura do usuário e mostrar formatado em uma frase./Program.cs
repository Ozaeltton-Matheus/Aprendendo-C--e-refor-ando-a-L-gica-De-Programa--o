// 1. Peça nome, idade e altura do usuário e mostre formatado em uma frase.

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a sua altura em (metros):");
float altura = Convert.ToSingle(Console.ReadLine()); // Convert.ToSingle() é usado para converter para float.

Console.WriteLine($"Bem, {nome}, você tem {idade} anos e sua altura é de {altura} metros!");
// Por alguma estranha razão se na altura colocar . (ponto) no lugar de , (virgula) o programa dá erro.