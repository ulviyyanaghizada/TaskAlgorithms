//1. Array-dakı ən böyük ədədlə ən kiçik ədədin yerini dəyişən alqortim yazın

int[] numbers = { 12, 56, 78, 43, 87, 33, 16 };
int min = numbers[0];
int max = numbers[0];
int change = 0;
int min_index = 0;
int max_index = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
        max_index = i;
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
        min_index = i;
    }
}
change = numbers[min_index];
numbers[min_index] = numbers[max_index];
numbers[max_index] = change;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.ReadLine();



//2.Daxil edilən ədədin rəqəmlərinin təkrar olub-olmamasını yoxlayın
//(Məs: 19076 - təkrar rəqəmlər yoxdu, 9089 - təkrarlanmış rəqəm(lər) var)

int num = 347880, count = 0, num1;
for (int i = 0; i <= 9; i++)
{
    num1 = num;
    count = 0;
    while (num1 != 0)
    {
        int end = num1 % 10;
        if (end == i)
        {
            count++;
        }
        num1 /= 10;
    }
    if (count > 1)
    {
        Console.WriteLine("tekrarlanmis reqemler var");
        Console.ReadLine();
        return;
    }
}
Console.WriteLine("tekrarlanma yoxdur");
Console.ReadLine();

