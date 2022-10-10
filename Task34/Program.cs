// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int GetEven(int[] arr)
{
    int even = 0;
for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] % 2 == 0)
        even ++;
    }
    return even;
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
Console.WriteLine("Колличество четных чисел: " +  GetEven(massiv));
