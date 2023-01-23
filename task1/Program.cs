//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");

string num = Console.ReadLine();
int numF = 0;
int numE = num.Length - 1;

if (numE == 4)
{
    while (numF < numE && Char.IsDigit(num[numF]) && Char.IsDigit(num[numE]))
    {
        if (num[numF] == num[numE])
        {
            numF++;
            numE = numE - 1;
        }
        else
        {
            Console.WriteLine($"{num[numF]} != {num[numE]} : число {num} не является палиндромом");
            numF = 5;
        }
    }
    if (numF == 2) Console.WriteLine($"число {num} является палиндромом");
    if (numF != 2 && numF != 5) Console.WriteLine($"{num} не верный ввод");
}
else Console.WriteLine("Значение не пятизначное");
