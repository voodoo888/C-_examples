// string[,] table = new string[2, 5];
// // String.Empty
// // table[0, 0] .. table[0, 4]
// // table[1, 0] .. table[1, 4]

// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// // Заполнене матрицы числами
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1; 10)
//         }
//     }
// }


// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);

// int[,] pict = new int[,]
// {
//     {1, 0, 1, 0},
//     {1, 0, 0, 0}
// };

// void FillImage(int row, int col)
// // Получает на вход точку начальную 
// // закрашивает область где находится эта точка
// {
//     if (pict[row, col] == 0)
//     {
//         pict[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);

//     }
// }

int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if((n == 1) | (n == 0))
    {
        return 1;
    }
    else 
    {
        return n * Factorial(n -1);
    }
}

Console.WriteLine(Factorial(5));


