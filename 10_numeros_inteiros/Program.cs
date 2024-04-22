int[] numeros = new int[10];

Console.WriteLine("Digite 10 numeros inteiros");

for (int i = 0; i < 10 ; i++)
{
    Console.WriteLine($"{i+1}º valor:");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.Write("Pares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] != 0 && numeros[i] % 2 == 0 )
    {
        Console.Write($"{numeros[i]},");
    }
}

Console.Write("\nimpares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.Write($"{numeros[i]}, ");
    }
}

Console.WriteLine("\nPrimeira opção: " + numeros[0] + " Ultima opção: " + numeros[9]);

    