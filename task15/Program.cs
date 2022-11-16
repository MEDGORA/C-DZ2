Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>7 || number<1)
{
    Console.Write($"Введите цифру от 1 до 7");
}
else
{
    if (number > 0  && number < 6)
    {
        Console.Write($"Нет, данный день недели рабочий");
    }
    if (number > 5  && number < 8)
    {
        Console.Write($"Да, данный день недели выходной");
    }
}
