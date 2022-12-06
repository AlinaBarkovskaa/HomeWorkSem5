int[] GetArray (int n)  //Задача Статистика
{
   int[] array = new int[n];
   for (int i = 0; i < n; i++)
   {
       Console.Write("Введите элемент массива от 1 до 31: ");
       int a = Convert.ToInt32(Console.ReadLine());
       array[i] = a;     
   }
   return array;
}

int GetCountEvenAndOddDays (int[] array)
{
    int countEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] % 2 == 0)
       {
         countEven ++;
       }  
    }
    return countEven;
}

 int GetCountOddDays (int[] array)
 {
    int countOdd = 0; 
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2  > 0)
        {
           countOdd ++;
        }
    }  
    return countOdd;
 }

Console.Clear();
Console.Write("Введите кол-во элементов массива от 1 до 99: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = GetArray(n);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
int rezultEven = GetCountEvenAndOddDays (mas);
Console.WriteLine($"Количество четных дней в которые Вася получал 4 = {rezultEven}" );
int rezultOdd = GetCountOddDays (mas);
Console.WriteLine($"Количество не четных дней в которые Вася получал 3 = {rezultOdd}" );
if(rezultEven >= rezultOdd)
{
   Console.WriteLine("Yes, Вася может расчитывать на 4!");
}else
{
   Console.WriteLine("No, Вася не может расчитывать на 4!");
}



