int[] GetArrayRandomNumbers(int n)
{
   int[] array = new int[n];
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = new Random().Next(100,1000);
   }
   return array;
}
int GetCountEvenNumbers(int[] array)
{
    int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
     if(array[i] % 2 == 0)
     {
       count++;
     }
  }
  return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = GetArrayRandomNumbers(n);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
int rezult = GetCountEvenNumbers(mas);
Console.WriteLine($"Четных чисел в массиве = {rezult}");