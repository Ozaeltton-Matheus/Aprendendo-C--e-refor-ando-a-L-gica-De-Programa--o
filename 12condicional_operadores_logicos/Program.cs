// Criação das variáveis
Console.WriteLine("Qual é o valor da compra?\nDigite o valor da compra: ");
double ?valor_da_compra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual será o tipo de pagamento?\nDIgite o tipo do pagamento\nDigite \n(1) Para Á vista \n(2) para à praso ");
double? forma_de_pagamento = Convert.ToDouble(Console.ReadLine());

if (valor_da_compra >= 100 && forma_de_pagamento == 1)
{
    Console.WriteLine($"Desconto de 10 %! total a pagar RS{valor_da_compra * 0.9}");
}

else
{
    Console.WriteLine($"O total da compra foi R${valor_da_compra}");
}

