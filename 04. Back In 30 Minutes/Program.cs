int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());


for (int i = 1; i <= 30; i++)
{
    minutes++;
    if (minutes == 60)
    {
        hours++;
        minutes = 0;
    }
    if (hours == 24)
    {
        hours = 0;
    }


}
Console.WriteLine($"{hours}:{minutes:d2}");