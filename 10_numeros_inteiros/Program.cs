int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];

Console.WriteLine("Digite 10 numeros inteiros");

for (int i = 0; i < 10 ; i++)
{
    Console.WriteLine($"{i+1}º valor:");
    numeros[i] = int.Parse(Console.ReadLine());

    for (int j = i; j == i; j++)
    {
        if (numeros[i] % 2 == 0)
        {
            pares[j] = numeros[i];
        }
        else
        {
            impares[j] = numeros[i];
        }
    }
}
Console.Write("Pares: ");
for (int i = 0; i < 10; i++)
{
    if (pares[i] != 0)
    {
        Console.Write($"{pares[i]},");
    }
}

Console.Write("\nimpares: ");
for (int i = 0; i < 10; i++)
{
    if (impares[i] != 0)
    {
        Console.Write($"{impares[i]}, ");
    }
}

Console.WriteLine("\nPrimeira opção: " + numeros[0] + " Ultima opção: " + numeros[9]);

    