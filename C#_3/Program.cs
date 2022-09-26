/*int[] point_A = { 1, 2 };
int[] point_B = { 4, 2 };
int [] result = {point_A[0] - point_B[0], point_A[1] - point_B[1]};
int result1 = 0;
for (int index = 0; index < result.Length; index++)
{
    result[index] = result[index] * result[index];
    result1 += result[index];
}
Console.Write($"Расстояние равно {Math.Sqrt(result1)}");

int number = Convert.ToInt32(Console.ReadLine());
string answer = "Нет";
if (((number / 10000) == (number % 10)) && (((number % 10000)/1000) == ((number % 100)/10)))
{
    answer = "Да";
}
Console.WriteLine(answer);

*/

int[] point_A = { 2, 1, -7};
int[] point_B = { 3, 6, 8};
int [] result = {point_A[0] - point_B[0], point_A[1] - point_B[1], point_A[2] - point_B[2]};
int sum_of_square = 0;
for (int index = 0; index < result.Length; index++)
{
    result[index] = result[index] * result[index];
    sum_of_square += result[index];
}
Console.Write($"Расстояние равно {Math.Sqrt(sum_of_square)}");

/*
int number = Convert.ToInt32(Console.ReadLine());
for (int index = 1; index < number + 1; index ++)
{
    Console.Write($"{Math.Pow(index, 3)}, ");
}
*/