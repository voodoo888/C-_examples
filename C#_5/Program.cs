/*
void MaxNum(int x, int y)
// Данная фунция выводит результат в консоль но ничего не возвращает.
{
    if (x > y)
    {
        Console.WriteLine($"{x} is max");
    }
    else 
    {
        Console.WriteLine($"{y} is max");
    }
}
int x1 = 5;
int x2 = 4;
MaxNum(x1, x2);

int MinNum(int x, int y)
// Данная фенкция возвращает значение int 
{
    if (x < y)
    {
        return x;
    }
    else
    {
        return y;
    }
}

int minNum = MinNum(x1, x2);
Console.WriteLine(minNum);
*/

/*
int count = 12;
int [] numbers = new int [count]; 
for (int index = 1; index < count; index ++)
{
    int nextNumber = new Random().Next(-9,10);
    numbers[index] = nextNumber;
}


var str = string.Join(" ", numbers);  // Напечатать массив в консоль (один из способов) 
Console.WriteLine(str);

int positive = 0;
int negative = 0; 

for (int i = 0; i < numbers.Length; i ++)
{
    if (numbers[i] < 0)
    {
        negative -= numbers[i];
        numbers[i] = 0 - numbers[i];
    }
    else if (numbers[i] > 0)
    {
        positive += numbers[i];
        numbers[i] = 0 - numbers[i];
    }
}
Console.WriteLine($"Сумма положительных равна {positive} \nСумма отрицательных равна {negative}");

var strR = string.Join(" ", numbers);  // Напечатать массив в консоль (один из способов) 
Console.WriteLine(strR);

void FoundNum (int x, int [] numbers)
{
    string flag = "NO";
    for (int j = 0; j < numbers.Length; j ++)
    {
        if (x == numbers[j])
        {
            flag = "YES";
        }
    }
    Console.WriteLine(flag);
}

FoundNum(4, numbers);

*/

/*
int count = 123;
int [] newNumbers = new int [count];
for (int i = 1; i < count; i ++)
{
    newNumbers[i] = new Random().Next(-1000, 1000);
}

var str3 = string.Join(" ", newNumbers);
Console.WriteLine(str3);

int counter = 0;
for (int i = 0; i < newNumbers.Length; i ++)
{
    if ((newNumbers[i] > 9) && (newNumbers[i] < 100))
    {
        counter += 1;
    }
}
Console.WriteLine(counter);

*/

/*

int len = 11;
int [] array = new int [len];
for (int i = 1; i < len; i ++)
{
    array[i] = new Random().Next(0, 10);
}

var str4 = string.Join(" ", array);
Console.WriteLine(str4);
int lenArray = 0;
if (array.Length % 2 == 0)
{
    lenArray = array.Length / 2;
}
else
{
    lenArray = array.Length / 2 + 1;
}

int [] productArray = new int[lenArray];

if (array.Length % 2 == 0)
{
    for (int i = 0; i < array.Length / 2; i ++)
    {
        productArray[i] = (array[i] * array[array.Length - i - 1]);
    }
}
else
{
    for (int j = 0; j < array.Length / 2 + 1; j ++)
    {
        if (j == array.Length / 2)
        {
            productArray[j] = array[j];
        }
        else 
        {
            productArray[j] = (array[j] * array[array.Length - j - 1]);
        }
    }
}

var str5 = string.Join(" ", productArray);
Console.WriteLine(str5);
*/

/*

// task number 34


int [] array34 = new int[10];
for(int i = 0; i < array34.Length; i ++)
{
    array34[i] = new Random().Next(100, 1000);
}

int counter = 0;
for (int i = 0; i < array34.Length; i ++)
{
    if (array34[i] % 2 == 0)
    {
        counter += 1;
    }
}

var str6 = string.Join(" ", array34);
Console.WriteLine(str6);
Console.WriteLine(counter);
*/

/*

// task 36

int [] array36 = new int[10];
for(int i = 0; i < array36.Length; i ++)
{
    array36[i] = new Random().Next(0, 100);
}

int positiveSumm = 0;
for (int i = 0; i < array36.Length; i ++)
{
    if (array36[i] % 2 != 0)
    {
        positiveSumm += array36[i];
    }
}

var str36 = string.Join(" ", array36);
Console.WriteLine(str36);
Console.WriteLine(positiveSumm);

*/
/*
// task 38

int [] array38 = new int[10];
for(int i = 0; i < array38.Length; i ++)
{
    array38[i] = new Random().Next(-100, 100);
}

int result = 0;

int MinNum(int [] array)
{
    
}

var str38 = string.Join(" ", array38);
Console.WriteLine(str38);
Console.WriteLine(positiveSumm);

*/

// test



double SquareOfRound (double r)
// Возвращает площадь круга
{
    double squareOfRound = Math.PI * (r * r);
    return squareOfRound;
}

double n1 = SquareOfRound(2);
Console.WriteLine(n1);



double SquareOfTreang (double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double squareOfTreang = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  // По формуле Герона

    //Проверка на то, является ли прямоугольник треугольным
    double maxLenght = 0;
    if (a > b)
    {
        maxLenght = a;
    }
    else
    {
        maxLenght = b;
    }
    if (maxLenght < c)
    {
        maxLenght = c;
    }

    if ((a * a) + (b * b) == (c * c))
    {
        Console.WriteLine($"Треугольник со сторонами {a} {b} {c} является прямоугольным");
    }
    else 
    {
        Console.WriteLine($"Треугольник со сторонами {a} {b} {c} не вляется прямоугольным");

    }

    return squareOfTreang;
}

double n2 = SquareOfTreang(3, 4 , 5);
Console.WriteLine(n2);