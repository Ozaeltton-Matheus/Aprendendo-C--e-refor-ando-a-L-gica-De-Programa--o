// Condicional simples, só if e else
// Variável de idade
// Se o if tiver somente uma linha o uso das chaves é opcional mas, se o if tiver mais de uma linha as chaves são obrigatórias. Por convensão é recomendável sempre colocar as chaves independente da quantidade de linhas que a comdicional tiver

int idade = 16;

// condicional para dizer se pode ou não pode tirar CNH No C# as chaves são em baixo do lado também funciona mas, não é recomendado
if(idade >= 18)
{
    Console.WriteLine("Você pode obter a CNH!");
}

else
{
    Console.WriteLine("Você não pode obter CNH!");
}
