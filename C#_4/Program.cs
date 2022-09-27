/*

//Number 1

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int answer = num1;
for (int i = 1; i < (num2); i++)
{
    answer *= num1;
}
Console.WriteLine($"{num1} в степени {num2}:");
Console.WriteLine(answer);

// Number 2

int number = Convert.ToInt32(Console.ReadLine());
int temp = 0;
while (number > 0)
{
    temp += number % 10;
    number = number / 10;
}
Console.Write(temp);
*/

// Number 3

int count = 8;
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    int nextNumber = new Random().Next(1,10);
    array[i] = nextNumber;
}

string WriteArray (int[] array)
// Функция которая печатает элементы массива через запятую и в квадратныйх скобках.

{
    string temp = "";
    string result = "[";
    for (int i = 0; i < array.Length; i ++)
    {
        temp = temp + $"{array[i]}, ";
    }

    for (int i = 0; i < temp.Length - 2; i ++)
    {
        result = result + temp[i];
    }
    result = result + "]";
    return result;
}

string str = WriteArray(array);
Console.Write(str);