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
int Reverse(int num)
{
    int current = 0;
    int rev = 0;   
    while (num > 0)
    {
    current = num % 10;
    rev = rev*10 + current;
    num = num / 10;
    }
    return rev;
}
int reverse = Reverse(num);
    if (num == reverse)
    {
        System.Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {num} - не палиндром");
    }