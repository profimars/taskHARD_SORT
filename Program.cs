// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
//https://github.com/profimars/taskHARD_SORT

void CreateMatrix(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 100);
        }
}

void PrintMatrix(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}  ");
        Console.WriteLine();
    }
}

void SortMatrix(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Console.WriteLine();
    int k = 0;
    int size = m * n;
    int[] AA = new int[size];
    //создаем одномерный массив АА
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            AA[k] = A[i, j];
            k++;
        }
    }
    PrintArray(AA);
    Console.WriteLine($"");
    for (int ii = 0; ii < size; ii++)
    {
        int jjj = 0;
        {
            int min = AA[ii];
            for (int jj = ii + 1; jj < size; jj++)
            {
                if (AA[jj] < min)
                {
                    min = AA[jj];
                    jjj = jj;
                    int q = AA[jjj];
                    AA[jjj] = AA[ii];
                    AA[ii] = q;
                }
            }
        }
    }
    PrintArray(AA);
    Console.WriteLine($"");
    Console.WriteLine($"");
    k = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            A[i, j] = AA[k];
            k++;
        }
    }
}

void PrintArray(int[] AA)
{
    for (int e = 0; e < AA.Length; e++)
        Console.Write($"{AA[e]}; ");
}

Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m, n];
CreateMatrix(A);
PrintMatrix(A);
SortMatrix(A);
PrintMatrix(A);

