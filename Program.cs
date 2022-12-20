// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
float [] arr = new float[size];
float max= arr[0];
float min= arr[0];
MaxandMinRandom(arr);

float result = max- min;

void MaxandMinRandom(float[] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-99,100);

    if (arr[i]> max)
    {
        max = arr[i];
    }
    else if ( arr[i]< min)
    {
        min = arr[i];
    }
}
}
System.Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Разница между максимальным и минимальным значением { result}");
