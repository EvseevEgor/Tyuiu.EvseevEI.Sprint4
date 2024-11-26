using Tyuiu.EvseevEI.Sprint4.Task4.V8.Lib;
namespace Tyuiu.EvseevEI.Sprint4.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Евсеев Е.И | ИИПБ-24-2";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #4                                                               #");
            Console.WriteLine("# Тема: Двумерные массивы. (ввод с клавиатуры)                            #");
            Console.WriteLine("# Задание #4                                                              #");
            Console.WriteLine("# Вариант #8                                                              #");
            Console.WriteLine("# Выполнил Евсеев Егор Игоревич | ИИПБ-24-2                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        #");
            Console.WriteLine("# значениями с клавиатуры в диапазоне от 1 до 6. Заменить четные элементы #");
            Console.WriteLine("# массива на 1.                                                           #");
            Console.WriteLine("# 1, 3, 2, 2, 5,                                                          #");
            Console.WriteLine("# 6, 1, 5, 5, 2,                                                          #");
            Console.WriteLine("# 1, 5, 4, 1, 4,                                                          #");
            Console.WriteLine("# 4, 1, 4, 4, 5,                                                          #");
            Console.WriteLine("# 4, 6, 1, 1, 4                                                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int[,] matrix = new int[5, 5];
            Console.WriteLine("Введите элементы матрицы через Enter");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = x;
                }
            }
            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Резулютирующая матрица: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
 
