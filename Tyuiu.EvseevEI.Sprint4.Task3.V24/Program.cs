using Tyuiu.EvseevEI.Sprint4.Task3.V24.Lib;
namespace Tyuiu.EvseevEI.Sprint4.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 3, 6, 1, 7, 3},
                                           {  2, 3, 7, 1, 1 },
                                           { 1, 2, 5, 5, 1},
                                           {7, 6, 7, 6, 2 },
                                           { 7, 6, 4, 5, 8 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Console.Title = "Спринт #4 | Выполнил: Евсеев Е.И | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич  | ИИПБ-24-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8.                          *");
            Console.WriteLine("* Найдите минимальный элемент во втором столбце массива.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальный элемент во втором столбце массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
  
