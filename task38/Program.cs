 double[] GetArrayRandomNumbers(int n)
 {
    double[] array = new double[n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Math.Round(rand.NextDouble() * (100 - (-100)) ,2);
    }
    return array;
 }

 double SearchMax(double[] array)
 {
   double max = 0;
   for(int i = 0; i < array.Length; i++)
   {
      if(max < array[i])
      {
         max = array[i];
      }
   }
   return max;
 }

 double SearchMin(double[] array)
 {
   double min = array[0];
   for(int i = 0; i < array.Length; i++)
   {
      if(min > array[i])
      {
         min = array[i];
      }
   }
   return min;
 }
 double showDifferenceBetweenMaxAndMin(double[] array)
 {
   double rezult = SearchMax(array) - SearchMin(array);
   return rezult;
 }
 Console.Clear();
 Console.Write("Введите кол-во элементов массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
 double[] mas = GetArrayRandomNumbers(n);
 Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
 double maxNumbers = SearchMax(mas);
 Console.WriteLine($"Максимальный элемент массива: {maxNumbers}");
 double minNumbers = SearchMin(mas);
 Console.WriteLine($"Минимальный элемент массива: {minNumbers}");
 double rez = showDifferenceBetweenMaxAndMin(mas);
 Console.WriteLine($"Разница между максимальным и минильным элементами = {rez}");

