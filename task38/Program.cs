// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// тип double 
double[] array = new double[5];

	
for (int i = 0; i < array.Length; i++)	
{	
 int n = 1+i;	
 Console.Write("\n Введите " + n + " элемент массива : " );	
 // array[i] = double.Parse(Console.ReadLine());	
 array[i] = Convert.ToDouble(Console.ReadLine());	
}	

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)	
 {
  if (max < array[i])
  {
    max = array[i];
  }
  if (min > array[i])
  {
    min = array[i];
  } 
}

double result;
result = max -min;

Console.WriteLine("\n Введен массив из 5 элементов"); // 34,6 ; 83,75 ; 82,9 ; 12,43 ; 12,9
Console.WriteLine(string.Join(" ; ", array));
Console.WriteLine("Максимальное значение элементов массива: "+ max);
Console.WriteLine("Минимальное значение элементов массива: "+ min);
Console.WriteLine("Разница между максимальным и минимальным значением элементов массива: " + result);