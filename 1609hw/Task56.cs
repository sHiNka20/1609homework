int vvod(String mass)
{
    Console.Write(mass);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] elemarr(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int b = 0; b < col; b++)
        {
            Console.Write($"Задайте {b + 1}-й элемент {i + 1}-ой строки массива : ");
            arr[i, b] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return arr;
}

int printarr(int[,] arr, int row, int col)
{

    for (int i = 0; i < row; i++)
    {
        Console.Write("[");
        for (int b = 0; b < col; b++)
        {
            Console.Write($"{arr[i, b]}, ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine("");
    Console.WriteLine("");
    return 0;
}
int summa(int[,] arr, int row, int col)
{
    int stroka = 1;
    int minsum = 0;
    int sum = 0;
    
    for (int z = 0; z < col; z++)
    {
        minsum = minsum + arr[0, z];
    }

    for (int i = 0; i < row; i++)
    {
        sum = 0;

        for (int b = 0; b < col; b++)
        {
            sum = sum + arr[i, b];
        }

        if (minsum > sum)
        {
            minsum = sum;
            stroka = i + 1;
        }
    }
    return stroka;
}

int row = vvod("Введите количество столбцов массива : ");
int col = vvod("Введите количество строк массива : ");

int[,] arr = elemarr(row, col);

printarr(arr, row, col);
Console.WriteLine($"Наименьшая сумма элементов в {summa(arr, row, col)}-й строке");