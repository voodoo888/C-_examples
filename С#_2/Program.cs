/*int n = 10;
while (n > 3)
{
    Console.WriteLine(n);
    n -= 1;
}

for (int i = 3; i < 10; i++)
{
    int x = new Random().Next(1, 100);
    Console.WriteLine($"Hello! {x} - {i}");
}

int n = new Random().Next(10, 99);
int m = new Random().Next(10, 99);
int counter = 0;
while (n % m != 0)
{
    counter += 1;
    Console.WriteLine($" {counter} {n} не кратно {m}, остаток {n % m}");
    n = new Random().Next(10, 99);
    m = new Random().Next(10, 99);
}
counter += 1;
Console.WriteLine($"{counter} - {n} кратно {m}");

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.Write((num % 100) / 10);

Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write((num % 1000) / 100 );
}
*/
/*
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if ((num == 7) || (num == 6))
{
    Console.Write($"День {num} - выходной");
}
else
{
    Console.Write($"День {num} - рабочий");
}
*/

Console.WriteLine("Введите любое число: ");
string number = Console.ReadLine();
if (number.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет");
} 
else
{
    Console.WriteLine(number[2]);
}

