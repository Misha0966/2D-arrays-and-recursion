 //m = 3, n = 4.
        
        //0,5 7 -2 -0,2
        //1 -3,3 8 -9,9
        //8 7,8 -7,1 9

        
        Console.WriteLine("Задайте двумерный массив размером mхn."); // условие задачи
        Console.WriteLine("Введите m:"); // создание кнопки для ввода переменной m
        int rowLength = Convert.ToInt32(Console.ReadLine()); // вычисление для значения m, которой соответствует кол-во строк
        Console.WriteLine("Введите n:"); // создание кнопки для вввода переменной n
        int columnLength = Convert.ToInt32(Console.ReadLine()); // вычисление для значения n, которой соответствует кол-во столбцов
        
        double[,] twoDimensionalArray = new double[rowLength, columnLength]; // создание двумерного массива
        RandomFillTwoDimensionalArray(twoDimensionalArray); // заполнение двумерного массива случайными числами
        PrintArray(twoDimensionalArray); // печать массива

        static void RandomFillTwoDimensionalArray(double[,] array) // метод заполнения двумерного массива случайными вещественными числами
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * new Random().Next(-10, 10); // определение интервала заполнения массива случайными числами
                }
            }
        }

     static void PrintArray(double[,] incomingArray) // метод печати массива
        {
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
        Console.Write($"{Math.Round(incomingArray[i, j], 2)} ");
        }
        Console.WriteLine();
        }
        }
        