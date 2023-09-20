// See https://aka.ms/new-console-template for more information
char again = '1';
while (again == '1')
{
    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine(total);
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine(total);
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine(total);
    }

    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine(total);
    }
    else if (oper == '%')
    {
        total = a / 100; 
        Console.WriteLine(total);
    }
    else if (oper == '^')
    {
        int x = (int)a;
        int y = (int)b;
        total = x ^ y;
        Console.WriteLine(total);
    }
    else
    {
        Console.WriteLine("Неизвестный оператор.");
    }
    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (1 = да, 2 = нет)");
    again = Convert.ToChar(Console.ReadLine());
}