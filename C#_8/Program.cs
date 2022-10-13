// Задайте двумерный массив. Напишите программу которая меняет первую и последнюю строку массива.


int [,] FillArr (int n, int m)
{   
    int [,] result = new int [n , m];
    for (int i = 0; i < n; i ++)
    {
        for (int j = 0; j < m; j ++)
        {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

void PrintArray(int [] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
// Печатает двумерный массив
void PrintArray2(int [,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void GetValue(int m, int n, int [,] arr)
{
    if ((m < arr.GetLength(0)) && (n < arr.GetLength(1)))
    {Console.WriteLine(arr[m, n]);}
    else 
    {Console.WriteLine("Такого элемента нет");}
}




int [,] ChangeValueFirstLast(int [,] arr)
{
    int [] tempArr = new int [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            if (i == 0)
            {
                tempArr[j] = arr[i, j];
                arr[i,j] = arr[arr.GetLength(0) - 1, j];
            }
            if (i == arr.GetLength(0) - 1)
            {
                arr[i,j] = tempArr[j];
            }
        }
    }
    
    return arr;
}


// int [,] newArr53 = FillArr(4, 4);
// PrintArray2(newArr53);
// Console.WriteLine();

// int [,] NewArrTemp = ChangeValueFirstLast(newArr53);
// PrintArray2(NewArrTemp);
// GetValue(newArr53.GetLength(0) - 1, newArr53.GetLength(1) - 1, newArr53);

int [,] ChangeValueFirstLast2(int [,] arr)
{
    int [,] resultArr = new int [arr.GetLength(0), arr.GetLength(1)];
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Это невозможно");
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            resultArr[i,j] = arr[j, i];
        }
    }
    
    return resultArr;
}
// int [,] resultArr = ChangeValueFirstLast2(newArr53);
// PrintArray2(resultArr);

// Удаляет строку из двумерного массива
int [,] DelRow( int[,] Arr, int row)
{
    int [,] result = new int [Arr.GetLength(0)-1, Arr.GetLength(1)];
    int x = 0;
    for (int i = 0; i < Arr.GetLength(0); i ++)
    {
        if (i == row){continue;}
        for (int j = 0; j < Arr.GetLength(1); j ++)
        {
            {
                result[x, j] = Arr[i, j];
            }
        }
        x++;
    }
    Arr = result;
    return Arr;
}

// Удаляет колонку из двумерного массива
int [,] DelCol( int[,] Arr, int col)
{
    int [,] result = new int [Arr.GetLength(0), Arr.GetLength(1)-1];
    
    for (int i = 0; i < Arr.GetLength(0); i ++)
    {   
        int y = 0;
        for (int j = 0; j < Arr.GetLength(1); j ++)
        {
            if (j == col){continue;}
            result[i, y] = Arr[i, j];
            y++;
        }
    }
    Arr = result;
    return Arr;
}


// newArr53 = DelCol(newArr53, 0);
// PrintArray2(newArr53);

int [,] arr55 = {
    {1, 2, 1, 2},
    {3, 2, 2, 2},
    {2, 2, 2, 2},
    {1, 3, 0, 4}

};




PrintArray2(arr55);
Console.WriteLine();
// arr55 = ModernArr(arr55, 2);

// PrintArray2(arr55);
// Удаляет заданные  строку и столбец из двумерного массива
int [,] DelColRow (int [,] array , int row, int col)
{
    int [,] result = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {continue;}
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == col){continue;}
            result[x, y] = array[i, j];
            y ++;
        }
        x ++;
    }
    return result;
}


// int [,] testArr55 = DelColRow(arr55, 1, 1);
// PrintArray2(testArr55);

// Проверяет на наличие элемента в массиве.
int Inner (int [,] array, int x)
{
    int result = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (x == array[i, j])
            {
                result = 1;
            }
        }
    }
    return result;
}

// Удаляет строку и столбец указанной цифры во всем массиве. Рекурсивная функция
int [,] ModernArr(int [,] arr, int x)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            if (arr[i, j] == x)
            {
                arr = DelColRow(arr, i, j);
            }
        }
    }
    if (Inner(arr, x) == 1)
    {
        arr = ModernArr(arr, x);
    }
    return arr;
}

int [,] testarr11 = ModernArr(arr55, 0);
PrintArray2(testarr11);

//////////////////////////////////////////////////
////////////////// HOME WORK /////////////////////
//////////////////////////////////////////////////

// 54 Задайте двумерный массив. Напишите программу которая упорядочит по убыванию каждую строку двумерного массива



// 56 Задайте пррямоугольный двумерный массив, напишите программу которая будет находить строку с наименьшей суммой элементов
// 58 Задайте две матрицы. Напишите программу, напишите программу которая будет находить произведение двух матриц
// 60 Сформируй трехмерный массив из неповторяющихся трехмерных чисел. Напишите программу, которая будет которая будет выводить массив построчно, добавляя индекс каждого элемента
// 62 Заполните спирально массив 4 на 4.

