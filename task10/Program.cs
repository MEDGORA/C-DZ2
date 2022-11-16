Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.Write($"Число {number} не является трёхзначным");
}
else
{
    int otvet = number/10 - number/100*10;
    Console.Write($"Второй цифрой числа {number} является {otvet}");
}
