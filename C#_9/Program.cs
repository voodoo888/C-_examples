string Numbers(int N)
{
    if (N == 1){return "1";}
    return $"{Numbers(N - 1)} {N}";
    
}
string result = Numbers(5);
Console.WriteLine(result);

int SumOfDigit (int num)
{
    if (num == 0) {return 0;}
    return num % 10 + SumOfDigit(num/10);
}

int x = SumOfDigit(1234343);
Console.WriteLine(x);

int APB(int a, int b)
{
    if (b == 0){return 1;}
    return a * APB(a, b - 1); 
}

int z = APB(3, 5);
Console.WriteLine(z);

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string NumbersList(int N)
{
    if (N == 1){return "1";}
    return $"{N} {NumbersList(N - 1)}";
    
}
string result64 = NumbersList(5);
Console.WriteLine(result64);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromNumbers(int a, int b)
{
    if (a == b){return a;}
    return b + SumFromNumbers(a, b - 1); 
}

int result66 = SumFromNumbers(3, 7);
Console.WriteLine(result66);
