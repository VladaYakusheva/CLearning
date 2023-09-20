
int num = int.Parse(Console.ReadLine());
int baseNum = num;

int count = 0;
bool pow = false;

while (num % 3 == 0)
{
    num /= 3;
    count++;

    if (num == 1)
    {
        pow = true;
        break;
    }
}

if (pow == true)
{
    Console.WriteLine($"число {Math.Pow(3, count)} является 3 в степени {count}");
}
else
{
    Console.WriteLine($"число {baseNum} НЕ является степенью числа 3");
}
