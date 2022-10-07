
// int count = 3;
// int[] numbers = new int[3];
// int index = 0;


// while (count > 0)
// {
//     int number = Convert.ToInt32(Console.ReadLine());
//     numbers[index] = number;
//     count -= 1;
//     index += 1;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// PrintArray(numbers);

// Console.WriteLine();

// int MaxNum(int[] array)
// {
//     int maxNum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (maxNum < array[i])
//         {
//             maxNum = array[i];
//         }
//     }
//     return maxNum;
// }

// int SumArray(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         result += array[i];
//     }
//     return result;
// }

// int n = SumArray(numbers);
// int m = MaxNum(numbers);

// if ((n - m) > m)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }
// Console.WriteLine(m);
// Console.WriteLine(n);


//Преобразование десятичного числа в двоичное

// void ToBinar(int n)
// {
//     int count = 1;
//     int k = n;
//     while (k > 1)
//     {
//         k = (k - (k % 2)) / 2;
//         count += 1;
//         // Console.WriteLine(k);
//     }

//     int[] numbers = new int[count];

//     for (int i = 0; i < count; i++)
//     {
//         numbers[count - i - 1] = n % 2;
//         n = n / 2;
//     }
//     PrintArray(numbers);
// }

// ToBinar(456);

//PrintArray(ToBinar(13));


// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// int[] arrayTest = new int[9];
// arrayTest = FillArray(arrayTest);
// PrintArray(arrayTest);
// Console.WriteLine();

// int[] ReversArray(int[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < ((array.Length) / 2); i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }


// ReversArray(arrayTest);
// PrintArray(arrayTest);
// int testNumber = arrayTest.Length; 
// Console.WriteLine(testNumber);

// void Fibanacci(int n)
// {
//     int temp = 0;
//     int n1 = 0;
//     int n2 = 0;
//     int i = 0;
//     while (i < n)
//     {
//         if (i == 0)
//         {
//             Console.Write($"{i}-");
//             n1 = i;
//         }
//         else if (i == 1)
//         {
//             Console.Write($"{i}-");
//             n2 = i;
//         }
//         else
//         {
//             temp = n2;
//             n2 = n1 + n2;
//             n1 = temp;
//             Console.Write($"{n2}-");
//         }

//         i++;
//     }
// }

// Fibanacci(7);

// int[] CopyArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < (array.Length - 1); i++)
//     {
//         result[i] = array[i];
//     }
//     return result;
// }

// int [] copyArray = CopyArray(arrayTest);
// arrayTest[0] = 555;
// PrintArray(arrayTest);
// Console.WriteLine();
// PrintArray(copyArray);
// for (int i = copyArray.Length - 1; i >= 0; i--)
// {
//     arrayTest[(copyArray.Length - 1) - i] = copyArray[i]; 
// }
// Console.WriteLine();
// PrintArray(arrayTest);


//ЗАДАЧА 41

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] arrayM = new int[m];
// int count = 0;
// for (int i = 0; i < m; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     arrayM[i] = Convert.ToInt32(Console.ReadLine());
//     if (arrayM[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Вы ввевли числа: ");
// PrintArray(arrayM);
// Console.WriteLine();
// Console.WriteLine($"Из них положительных {count} штук.");

// ЗАДАЧА 43

// void IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     if (k1 == k2)
//     {
//         if (b1 != b2)
//         {
//             Console.WriteLine("Линии параллельны и не пересекаюся");
//         }
//         else
//         {
//             Console.WriteLine("Линии повторяют друг друга");
//         }
//     }
//     else
//     {
//         double x = (b2 - b1)/(k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"Точка пересечения: ({x};{y})");
//     }
// }


// IntersectionPoint(2,5,4,5);