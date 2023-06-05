Console.Clear();

Console.Write(@"     --= Etanol ou Gasolina =--

Digite o preço do etanol (R$).....: ");
decimal Etanol = Convert.ToDecimal (Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
decimal Gases = Convert.ToDecimal (Console.ReadLine());

decimal porcentagem = (Etanol / Gases) * 100;

Console.WriteLine();
Console.WriteLine($"O preço do etanol corresponde a {porcentagem}% do preço da gasolina");

if (porcentagem >= 70)
{
    Console.Write("Recomendação: Abasteça com ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Gasolina"); 
    Console.ResetColor(); Console.WriteLine();
}

else
{
    Console.Write("Recomendação: Abasteça com ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Etanol"); 
    Console.ResetColor(); Console.WriteLine();
}

