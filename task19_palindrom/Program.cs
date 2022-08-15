// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

while (true)
{

    Console.WriteLine("Введите пятизначное число");

    int number = Convert.ToInt32(Console.ReadLine());


    bool check(int num)
    {
        string str = Convert.ToString(num);
        int length = str.Length - 1;
        bool result = true;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i])
            {
                result = false;
                break;
            }
            else
            {
                result = true;
            }
        }
        return result;
    }
    if (check(number))
    {
        Console.WriteLine("Введенное число - палиндром.");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром.");
    }
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}