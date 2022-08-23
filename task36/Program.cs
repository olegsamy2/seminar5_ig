// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];
Random rand = new Random();
int sum = 0;

Console.WriteLine("\n одномерный массив ");
for (int i = 1; i < array.Length; i=i+1)

 {
    array[i] = rand.Next(-99, 100);
    
    
    if (i % 2 != 0)
    {
      sum = sum+array[i];

    }
 }
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($" сумму элементов, стоящих на нечётных позициях = {sum}");