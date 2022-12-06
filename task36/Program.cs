int[] GetArrayRandomNumbers(int n)
{
   int[] array = new int[n];
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = new Random().Next(1,1000);
   }
   return array;
}
int GetSumNumbersEvenPosition(int[] array)
{
    int sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(i % 2 == 0)
    {
      sum = sum + array[i];
    }
  }
  return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = GetArrayRandomNumbers(n);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
int rezult = GetSumNumbersEvenPosition(mas);
Console.WriteLine($"Сумма чисел стоящих на четных позициях = {rezult}");
