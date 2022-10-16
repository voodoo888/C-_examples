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


// Заполняет заданный массив случайными числами 
int [] FillArray(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
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

// Находит индекс минимального значения одномерного массива
int IndexMinNum (int [] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == MinNum(array))
        {
            index = i;
        }
    }
    return index;
}

// Находит индекс минимального значения одномерного массива
int IndexMaxNum (int [] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == MaxNum(array))
        {
            index = i;
        }
    }
    return index;
}

// Функция печатающая одномерный массив
void PrintArray(int [] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

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

// int [,] arr55 = {
//     {1, 2, 1, 2},
//     {3, 2, 2, 2},
//     {2, 2, 2, 2},
//     {1, 3, 0, 4}

// };




// PrintArray2(arr55);
// Console.WriteLine();
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

// int [,] testarr11 = ModernArr(arr55, 0);
// PrintArray2(testarr11);

//////////////////////////////////////////////////
////////////////// HOME WORK /////////////////////
//////////////////////////////////////////////////

// 54 Задайте двумерный массив. Напишите программу которая упорядочит по убыванию каждую строку двумерного массива

//Формирует срез массива от индекса n до конца массива
int [] SliceArray(int [] array, int n)
{   

    int [] result = new int[array.Length - n];
    int index = 0;
    for (int i = n; i < array.Length; i++)
    {
        result[index] = array[i];
        index ++;
    }
    return result;
       
}


// Сортирует одномерный массив по убыванию 
int [] SortArray(int [] array)
{
    int k = array.Length;
    int [] result = new int [array.Length];
    for (int i = 0; i < k; i++)
    {
        int tempInd = IndexMaxNum(array);
        result[i] = MaxNum(array);

        int tempValue = array[0];
        array[0] = array[tempInd];
        array[tempInd] = tempValue;
        array = SliceArray(array, 1);
    }
    return result;
}

// Решение

// int [,] arr54 = FillArr(4, 4);
// PrintArray2(arr54);
// Console.WriteLine("Исходный Двумерный массив 54");
// int [,] result54 = new int [4, 4];
// for (int i = 0; i < arr54.GetLength(0); i++)
// {
//     int [] tempArr = new int [arr54.GetLength(1)];
//     for (int j = 0; j < arr54.GetLength(1); j++)
//     {
//         tempArr[j] = arr54[i, j];
//     }
//     for (int k = 0; k < tempArr.Length; k++)
//     {
//         result54[i,k] = tempArr[k];
//     }
// }

// PrintArray2(result54);
// Console.WriteLine("Отсортированный построчно Двумерный массив 54");

// 56 Задайте пррямоугольный двумерный массив, напишите программу которая будет находить строку с наименьшей суммой элементов

//Решение

// int [,] arr56 = FillArr(4, 4);
// PrintArray2(arr56);
// Console.WriteLine("Исходный Двумерный массив 56");

// int [] temp56 = new int [arr56.GetLength(1)];
// for (int i = 0; i < arr56.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < arr56.GetLength(1); j++)
//     {
//         sum += arr56[i, j];
//     }
//     temp56[i] = sum;
// }
// int result = IndexMaxNum(temp56);
// Console.WriteLine($"Строка с индексом {result} является строкой с максимальной суммой элементов");

// 58 Задайте две матрицы. Напишите программу, напишите программу которая будет находить произведение двух матриц


// Решение

// int [,] arr581 = FillArr(5, 3);
// PrintArray2(arr581);
// Console.WriteLine("Исходный Двумерный массив 581");

// int [,] arr582 = FillArr(3, 4);
// PrintArray2(arr582);
// Console.WriteLine("Исходный Двумерный массив 582");

// // УСЛОВИЕ ЧТО ЧИСЛО СТОЛБЦОВ СОВПАДАЕТ С ЧИСЛОМ СТРОК ДРУГОЙ МАТРИЦЫ ИНАЧЕ ВЫВЕСТИ НЕВОЗМОЖНО
// if (arr581.GetLength(1) != arr582.GetLength(0))
// {
//     Console.WriteLine("Умножение матриц не возможно.");
// }

// int [,] result = new int [arr581.GetLength(0), arr582.GetLength(1)];
// for (int i = 0; i < arr581.GetLength(0); i++)
// {
    
//     for (int j = 0; j < arr582.GetLength(1); j++)
//     {
//         int newValue = 0;
//         for (int k = 0; k < arr581.GetLength(1); k++)
//         {
//             newValue += arr581[i, k] * arr582[k, j];
//         }
//         result[i, j] = newValue;
//     }
// }
// PrintArray2(result);


// 60 Сформируй трехмерный массив из неповторяющихся трехмерных чисел. Напишите программу, которая будет которая будет выводить массив построчно, добавляя индекс каждого элемента

// //РЕШЕНИЕ
// int number  = 11;
// int [,,] threeDM  = new int [3, 3, 3];
// // FillArray
// for (int i = 0; i < threeDM.GetLength(0); i++)
// {
//     for (int j = 0; j < threeDM.GetLength(1); j++)
//     {
//         for (int k = 0; k < threeDM.GetLength(2); k++)
//         {
//             threeDM[i, j, k] = number;
//             number += 3;

//         }
//     }
// }

// // Printarray
// for (int i = 0; i < threeDM.GetLength(0); i++)
// {
//     for (int j = 0; j < threeDM.GetLength(1); j++)
//     {
//         for (int k = 0; k < threeDM.GetLength(2); k++)
//         {
//            Console.Write($"{threeDM[i, j, k]}({i},{j},{k})");
//         }
//         Console.WriteLine();
//     }
// }


// 62 Заполните спирально массив 4 на 4.

int [,] Array62 = new int [4, 4];


int [] StepRight ( int [] arr)
{
    arr[1] += 1;
    return arr;
}

int [] StepLeft ( int [] arr)
{
    arr[1] -= 1;
    return arr;
}

int [] StepDown ( int [] arr)
{
    arr[0] += 1;
    return arr;
}

int [] StepUp ( int [] arr)
{
    arr[0] -= 1;
    return arr;
}

int [] indexPos = new int [2];



// РЕШЕНИЕ (АНАЛОГОВОЕ)

int count = 1;
while (count < 4)
{
    indexPos = StepRight(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 7)
{
    indexPos = StepDown(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 10)
{
    indexPos = StepLeft(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 12)
{
    indexPos = StepUp(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 14)
{
    indexPos = StepRight(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 15)
{
    indexPos = StepDown(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}
while (count < 16)
{
    indexPos = StepLeft(indexPos);
    Array62[indexPos[0], indexPos[1]] = count;
    count += 1;
}


PrintArray(indexPos);
Console.WriteLine();
PrintArray2(Array62);



//Попытки сделать автоматизацию
// Функция которая проверяет есть ли данный индекс в массиве, во избежание ошибки  
// int SearchIndex (int [,] array, int [] indexPos)
// {
//     int result = 0;
//     if ((array.GetLength(0) <= indexPos[0]) | (array.GetLength(1) - 1 <= indexPos[1])) {result = 1;}
//     return result;
// }


// void SpiralFillArray(int [,] array)
// {
//     int count = 1;
//     int [] indexPosition = {0,0};
//     array[indexPosition[0], indexPosition[1]] = count;
//     while (count < 17)
//     {   
//         count += 1;

//         if (indexPosition[1] + 1 < array.GetLength(1))
//             {
//                 if (array[indexPosition[0], indexPosition[1] + 1] == 0)
//                 {
//                     indexPosition = StepRight(indexPosition);
//                     array[indexPosition[0], indexPosition[1]] = count;
//                     Console.WriteLine($"step {count} - {indexPosition[0]}, {indexPosition[1]} - array {array[indexPosition[0], indexPosition[1]]}");
//                 }
//             }
//         else if (indexPosition[0] + 1 < array.GetLength(1))
//             {
//                 if (array[indexPosition[0], indexPosition[1] + 1] == 0)
//                 {
//                     indexPosition = StepRight(indexPosition);
//                     array[indexPosition[0], indexPosition[1]] = count;
//                     Console.WriteLine($"step {count} - {indexPosition[0]}, {indexPosition[1]} - array {array[indexPosition[0], indexPosition[1]]}");
//                 }
//             }

//     }

// }


// PrintArray2(Array62);
// Console.WriteLine(Array62.GetLength(1));
// Console.WriteLine();
// SpiralFillArray(Array62);
// PrintArray2(Array62);


