// Realizar uma perguunta
Console.WriteLine("Qual é o seu mome?: ");

// Obter o nome
// Para armazenar é precisso criar a variavel

// O Console.ReadLine(); é semelhante ao input("") do Python
// O Console.ReadLine não garante que o usuário digitará alguma coisa e a variável que neste caso é nome obrigatóriamente precisa ter algum valor, por isso dá aquele erro de que não é possivél converter um valor nulo

// Para dizer ao C# que as variáveis podem receber uma informação nula, ou seja, em branco adicionamos ? antes do nome da variável
String ?nome = Console.ReadLine();

// Concatenação de variáveis
Console.WriteLine($"Olá, {nome}!");

Console.WriteLine("Qual é a sua idade?");
String ?idade = Console.ReadLine();

Console.WriteLine($"Ahh, então você tem {idade} anos, {nome}.");