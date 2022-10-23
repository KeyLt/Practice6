// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMass(int[,] massiv)
{
    Random rand = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = rand.Next(-10, 10);
        }
    }
}

void Obrabotka_indeksov(int[,] massiv)
{
    Random rand = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0) massiv[i, j] = massiv[i, j] * massiv[i, j];
        }
    }
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMass(massiv: array);
PrintMass(array);
Console.WriteLine("Обработанный массив");
Obrabotka_indeksov(array);
PrintMass(array);