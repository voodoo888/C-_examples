// Создает и заполняет двумерный массив натуральными числами от 1 до 10
int[,] FillArr(int n, int m)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

// Печатает двумерный массив
void PrintArray2(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Выводит на печать массив двумерный массив с вещественными числами
void PrintArrayDoble(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

/*
int[,] newArr = FillArr(3, 4);
Console.WriteLine(newArr[0,0]);
PrintArray2(newArr);
*/

// Создает и заполняет массив в котором каждый элемент равен сумме его индексов
int[,] FillArr2(int n, int m)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

/*
Console.WriteLine();
int[,] newArr2 = FillArr2(3, 4);
PrintArray2(newArr2);
*/

// Если оба индекса четные - то возвращает элемент в квадрате
int[,] ModifyArray(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                result[i, j] = arr[i, j] * arr[i, j];
            }
            else
            {
                result[i, j] = arr[i, j];
            }
        }
        Console.WriteLine();
    }
    return result;
}

/*
int[,] newArr3 = ModifyArray(newArr);
PrintArray2(newArr3);
Console.WriteLine();
*/

// Возвращает сумму элементов двумерного массива по главной диагонали
int SumOfMainDiag(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                result += arr[i, j];
            }
        }
    }
    return result;
}


// Задача № 47

//Создает и заполняет массив вещественными числами
double [,] FillArrR(int n, int m)
{
    double [,] result = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(-100, 100);
            result[i, j] = Math.Round(result[i, j], 2);
        }
    }
    return result;
}


double [,] array47 = FillArrR(3, 4);
PrintArrayDoble(array47);

Console.WriteLine();
// Задача № 50

// Выводит на печать значение элемента по заданным индексам
// если такого элемента нет - пишет что такого элемента нет
void GetValue(int m, int n, int [,] arr)
{
    if ((m < arr.GetLength(0)) && (n < arr.GetLength(1)))
    {Console.WriteLine($"Элемент с индексами {m},{n} - {arr[m, n]}");}
    else 
    {Console.WriteLine($"Элемента с индексами {m},{n} - нет в данном массиве");}
}

int [,] newArr50 = FillArr(3, 4);
PrintArray2(newArr50);
Console.WriteLine();

GetValue(1, 2, newArr50);
GetValue(5, 5, newArr50);
Console.WriteLine();


// Задача № 51
// Печатает строку из средних значений каждого столбца массива
void AVGPrintArray2(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i ++)
    {
        double temp = 0;
        double tempAVG = 0;
        for (int j = 0; j < arr.GetLength(0); j ++)
        {
            // Console.Write($"{arr[j, i]} ");
            temp += arr[j, i];
        }
        //Console.WriteLine();
        tempAVG = temp / arr.GetLength(0);
        Console.Write($"Среднее столбца c индексом{i} - {Math.Round(tempAVG, 2)} ");
        Console.WriteLine();
    }
}

int [,] newArr51 = FillArr(3, 4);
PrintArray2(newArr51);
AVGPrintArray2(newArr51);