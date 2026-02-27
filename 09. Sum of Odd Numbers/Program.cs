int input = int.Parse(Console.ReadLine());
int sum = 0;
int oddCount = 0;

for (int i = 1; i<= input * 2; i ++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
        sum += i;
        oddCount++;
    }
    if (oddCount == input)
    {
        Console.WriteLine($"Sum: {sum}");
        break;
    }
    
}