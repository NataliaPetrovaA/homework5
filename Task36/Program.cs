//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum += arr[i];
    }
    return sum;
}

int GetNumber()
{
    int N = 0;
    while (N < 1)
    {
       Console.WriteLine("Введите длину массива!");
       N = Convert.ToInt32(Console.ReadLine());  
    }
    return N;
}

int size = GetNumber();
int[] massiv = new int[size];
FillArray(massiv);
Console.WriteLine("массив: ");
PrintArray(massiv);
Console.WriteLine();
Console.WriteLine("Cумма элементов, на нечётных позициях: " +  GetSum(massiv));

