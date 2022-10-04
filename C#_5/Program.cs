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