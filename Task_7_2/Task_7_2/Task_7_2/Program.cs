// Decompiled with JetBrains decompiler
// Type: Task_7.Program
// Assembly: Task_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 903D11EF-B50F-423B-AC35-E238CBA402C0
// Assembly location: D:\GB\GeekBrains\Task_7\Task_7\bin\Debug\net5.0\Task_7.dll

using System;

namespace Task_7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      int[] array2 = new int[5]{ 1, 2, 3, 4, 5 };
      Console.WriteLine("Исходный массив:");
      foreach (int num in array2)
        Console.WriteLine(string.Format("    {0}", (object) num));
      Console.WriteLine("\nУмножение элементов массива на 3");
      Program.ModifyArray(array2);
      Console.WriteLine("Модифицированный массив: ");
      foreach (int num in array2)
        Console.WriteLine(string.Format("    {0}", (object) num));
    }

    private static void ModifyArray(int[] array3)
    {
      for (int index = 0; index < array3.Length; ++index)
        array3[index] *= 3;
    }
  }
}
