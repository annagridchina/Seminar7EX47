public class Library47
{
// Создание массива
  public static int[] CreateArray(int count)
  {
    return new int[count];
  }

// Заполнение числами от ... до ...
  public static void Fill(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Random.Shared.Next(100, 999);
    }
  }

// печать массива
  public static string Print(int[] array)
    {
    return String.Join(" ", array);
    }

// Метод Pow возведение в степень
// a^b =  a*a*a*...*a
//           b раз
  public static int Pow(int a, int b)
  {
    int result = 1;
    for (int i = 0; i < b; i++)
    {
      result = result * a;
    }
    return result;
  }

  // написать конвертор из 15-ой в 10-ую
  //  0  1  2   3 - i
  // [6, 4, 3, 10]
  //  3  2  1   0 - степени
  // 10 * 15^0 + 3 * 15^1 + 4 * 15^2 + 6 * 15^3
  public static int ToDec(int[] value)
  {
    int  result = 0;
    int count = value.Length;

    for (int i = 0; i < count; i++)
    {
      result += value[i] * Pow(15, count - 1 - i);
    }
    return result;
  }
  //Нахождение чётных чисел в массиве
  
//public static int Even(int[] value)
  // {
   //int value = 0;
  // int count = value.Length;

 // for (int i = 0; i < count; i++)
  //{
   // if (value % 2 == 0)
   // return value;
   //}
    //WriteLine($"{Print(ar)} => {even}");
  // }


 //Создание двумерного массива
//   public static int[] CreateMatrix(3,4)
//   {
//     return new int[count];
//   }


// Заполнение числами двумерного массива от ... до ...
  public static void FillMatrix(int[] matrix);
  {
    for (int i = 0; i < matrix.GetLenth(0); i++)
    {
     for (int j = 0; j < matrix.GetLenth(1); j++)  
      {
        matrix[i,j] = NewRandom().Next(10, 10);
      }
    }
  }
// Заполнение двумерного массива рандомными вещественными числами
public static void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

//  Функция вывода массива в терминал
public static void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода данных
public static int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
}