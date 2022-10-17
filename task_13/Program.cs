Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int tempNumber = number,
        lastNumber = tempNumber % 10;
    while (tempNumber / 1000 > 0)
    {
        tempNumber = tempNumber / 10;
        lastNumber = tempNumber % 10;
    }
    Console.WriteLine(lastNumber);
}

