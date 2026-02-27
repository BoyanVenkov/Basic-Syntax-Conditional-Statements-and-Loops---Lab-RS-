int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int result = num1 * num2;

if (num2 > 10)
{
    Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
}

for (int i = num2; i <= 10; i++)
{
    result = num1 * i;
    Console.WriteLine($"{num1} X {i} = {result}");
}