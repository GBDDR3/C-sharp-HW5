// Задайте  одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];
int[] FindNumber(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}
int[] result = FindNumber(array);

int count = 0;
for (int i = 1; i < result.Length; i += 2)
{
    Console.Write(result[i]);
    Console.Write(" ");
    count += result[i];

}
Console.Write(count);