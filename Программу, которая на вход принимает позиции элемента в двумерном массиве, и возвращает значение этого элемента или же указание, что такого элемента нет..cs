        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет

            int[,] array = GenerateNewTwoDimensionalArray(); //ввод двумерного массива
            string index = ReadNumberFromConsole(array.GetLength(0), array.GetLength(1));// определение строки индекса массива
            PrintTwoDimensionalArray(array); // печать двумерного массива
            SearchAndWriteNumberFromArray(index, array); // поиск числа из двумерного масива

        

        static int[,] GenerateNewTwoDimensionalArray() // метод создания двумерного массива
        {
            int[,] array = new int[3, 4]; // внесение размерности массива в соответствии с примером задачи
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10); // определение интервала заполнения заполнения массива случайными числами
                }
            }
            return array;
        }
        static string ReadNumberFromConsole(int index0=3, int index1=4) // метод чтения чисел в консоли
        {
            while (true)
            {
                             Console.WriteLine("В заданном массиве " + index0 + " строки " +
                "и " + index1 + " столбца.");
                Console.Write("Введите число от 1, где первая цифра будет номером строки, " +
                "а вторая номером столбца: ");
                string? inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out int number))
                {
                    return inputNumber;
                }
                Console.WriteLine("Вы ввели не число!");
            }
        }

        static void SearchAndWriteNumberFromArray(string index, int[,] array) // метод поска заданного числа
        {
            int[] digits = index.Select(c => (int)char.GetNumericValue(c)).ToArray(); // ввод целого числа, которому соответствует индекс заданного двумерного массива

            try //Блок, содержащий защищенный код, который может вызвать исключение
            {
                   Console.WriteLine(index + " -> " + array[(digits[0]) - 1, (digits[1]) - 1]);
            }
            catch (IndexOutOfRangeException) // оператор который обрабатывает исключение, при выходе из индексов заданного массива
            {
                Console.WriteLine(index + " -> такого числа в массиве нет (индекс " + index + " не существует)"); // ответ на пример задачи
            }
        }

         static void PrintTwoDimensionalArray(int[,] array) // метод печати массива
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }