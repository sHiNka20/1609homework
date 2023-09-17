int vvod(string mass)
{
    Console.Write(mass);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int[,] matrix(int num)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    int[,] mat = new int[num, num];

    while (temp <= mat.GetLength(0) * mat.GetLength(1))
    {
        mat[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < mat.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= mat.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > mat.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return mat;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else 
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}


printArray(matrix(vvod("Введите размерность матрицы : ")));


