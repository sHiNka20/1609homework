using System.Data;

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
int raspredel(int[,] arr, int row, int col)
{
    int save = 0;
    for (int i = 0; i < row; i++)
    {
        for (int b = 0; b < col; b++)
        {
            for (int a = b + 1; a < col; a++)
            {
                if (arr[i,b] < arr[i,a])
                {
                    save = arr[i,b];
                    arr[i,b] = arr[i,a];
                    arr[i,a] = save;
                }
            }
        }
    }
    return 0;
}

int row = vvod("Введите кольчество столбцов массива : ");
int col = vvod("Введите количество строк массива : ");

int[,] arr = elemarr(row, col);

printarr(arr, row, col);
raspredel(arr, row, col);
printarr(arr,row,col);

