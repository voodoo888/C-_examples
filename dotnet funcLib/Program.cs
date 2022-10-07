
// Функция печатающая одномерный массив
void PrintArray(int [] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

// Минимальное число последовательности
int MinNum(int [] array)
{
    int minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNum > array[i])
        {
            minNum = array[i];
        }
    } 
    return minNum;
}

// Максимальное число последовательности
int MaxNum(int [] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
    } 
    return maxNum;
}

//  СУММА ЧЛЕНОВ СПИСКА
int SumArray(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    return result;
}

// Функция перевода десятичного числа в двоичное
void ToBinar(int n)

{
    int count = 1;
    int k = n;
    while (k > 1)
    {
        k = (k - (k % 2)) / 2;
        count += 1;
        // Console.WriteLine(k);
    }
    
    int [] numbers = new int [count];
   
    for (int i = 0; i < count; i++)
    {
        numbers[count - i - 1] = n % 2;
        n = n / 2;
    }
    PrintArray(numbers);
}

// Заполняет заданный массив случайными числами 
int [] FillArray(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

// Переворачивает массив делая первый элемент последним и тд
int [] ReversArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < ((array.Length) / 2); i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

// Печатает N чисел фибаначи через дефиз
void Fibanacci (int n)
{
    int temp = 0;
    int n1 = 0;
    int n2 = 0;
    int i = 0;
    while (i < n)
    {
        if (i == 0)
        {
            Console.Write($"{i}-");
            n1 = i;
        }
        else if (i ==1)
        {
            Console.Write($"{i}");
            n2 = i;
        }
        else
        {
            temp = n2;
            n2 = n1 + n2;
            n1 = temp;
            Console.Write($"-{n2}");
        }

        i ++;
    }
}    

// Создает копию массива поэлементно
int [] CopyArray(int[] array)

{
    int [] result = new int [array.Length];
    for (int i = 0; i < (array.Length - 1); i++)
    {
        result[i] = array[i];
    }
    return result;
}

// Возвращает двумерный массив заполненый случайными числами от 1 до 9
int [,] FillArr (int n, int m)
{   
    int [,] result = new int [n , m];
    for (int i = 0; i < n; i ++)
    {
        for (int j = 0; j < m; j ++)
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
                result += arr[i,j];
            }
        }
    }
    return result;
}

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

// Выводит на печать значение элемента по заданным индексам
// если такого элемента нет - пишет что такого элемента нет
void GetValue(int m, int n, int [,] arr)
{
    if ((m < arr.GetLength(0)) && (n < arr.GetLength(1)))
    {Console.WriteLine(arr[m, n]);}
    else 
    {Console.WriteLine("Такого элемента нет");}
}

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