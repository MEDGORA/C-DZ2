Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100)
{
    Console.Write($"В числе {number} третьей цифры нет");
}
else
{
    // Ниже находим общее количество цифр в числе (i)
    int i = 0;                                    
    int a = 1;
    while (number/a != 0)
        {
            i++;
            a = Convert.ToInt32(Math.Pow(10,i));
        }
    
    int b = Convert.ToInt32(Math.Pow(10,(i-3))); // Переменная (b) нужна, чтобы далее отсеч первые три цифры числа
    int otvet = (number/b)%10; // Находим последнюю цифру из отсечённых первых трёх цифр
    Console.WriteLine($"Третьей цифрой числа {number} является {otvet}");
}
