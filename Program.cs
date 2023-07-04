/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Не использовать строки (только / и % используем)
14212 -> нет
12821 -> да
23432 -> да*/
int ReadInt(string msg)
{
    System.Console.Write(msg);              
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate5Digits(int number)
{
    if (10000 <= number && number <= 99999)
    {
        return true;
    }
    System.Console.WriteLine("Число не пятизначное");
    return false;
     
}
int num = ReadInt("Введите пятизначное число => ");
//if (Validate5Digits(num))
int Palindrom(int num)
{
    int r = 0;
    int rev = 0;   
    while (num > 0)
    {
    r = num % 10;
    rev = rev*10 + r;
    num = num / 10;
    }
    return rev;
}
int number = Palindrom(num);
    if (num == number)
    {
        System.Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {num} - не палиндром");
    }
