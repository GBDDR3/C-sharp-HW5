//    Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел 
// в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[4];

int[] FindNumber(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}
int[] result = FindNumber(arr);

int max = 0;

for (int i = 0; i < result.Length; i++)
{

    if (result[i] % 2 == 0)
    {

        max += 1;
    }
    Console.WriteLine(result[i]);
}
Console.WriteLine(max);