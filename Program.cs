int primeiro, segundo, maiorNumero;

Console.Write("Digite o primeiro numero...:");
primeiro = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero...:");
segundo = Convert.ToInt32(Console.ReadLine());

if (primeiro < segundo)
{
    maiorNumero= segundo;
}
else
{
    maiorNumero = primeiro;
}

Console.WriteLine($"o maior numero é {maiorNumero}");