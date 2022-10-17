Console.Write("Введите номер дня недели: ");
int weekDayNumber = Convert.ToInt32(Console.ReadLine());

if ( weekDayNumber < 1 || weekDayNumber > 7)
{
    Console.WriteLine("Число не соответствует дню недели");
}
else
{
    if (weekDayNumber == 6 || weekDayNumber == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}