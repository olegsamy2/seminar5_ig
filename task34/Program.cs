// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
 Random rand = new Random();
int count = 0;

Console.WriteLine("\n массив из трехзначных чисел");
for (int i = 0; i < array.Length; i++)

 {
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
      count ++;
    }
 }
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($" количество чётных чисел в массиве = {count}");