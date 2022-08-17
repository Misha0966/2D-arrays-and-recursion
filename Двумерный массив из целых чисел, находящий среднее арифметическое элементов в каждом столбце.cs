//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Array2_D(int row, int column, int from, int to) //метод coздания двумерного массива
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        array[i, j] = new Random().Next(from, to);
    return array;
}

void ArithmeticMean(int[,] array) //метод вычисления среднего арифметического в двумерном массиве
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    double result;

    for (int i = 0; i < column; i++)
    {
        result = 0;
        for (int j = 0; j < row; j++) result += array[j, i];
        Console.Write($"{Math.Round(result / row, 2)}; ");

    }

}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Array2_D(row, column, 1, 10);
Print(array_1);

ArithmeticMean(array_1);

void Print(int[,] array) //метод печати двумерного массива
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {array[i, j]} ");
            Console.WriteLine();
    }
    Console.WriteLine();
}