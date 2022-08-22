// Задайте  массив вещественных чисел. Найдите разницу  между 
// максимальным и минимальным элементов   массива.
// [3 7 22 2 78] -> 76

double[] array = { 0.5, 20, 1.3, 40, 7.8, 60, 5.555 };

double MinMaxNumber(double[] arr)
{
    double min = array[0];
    double max = array[0];
 // double res = max - min; //Если эту строку расскомментировать, а строку 19
 // закомментировать, то код работать не будет. res будет равен 0. Я не пойму
 //почему это так работает...
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double res = max - min;
    return res;
}

double result = MinMaxNumber(array);
Console.WriteLine(result);
