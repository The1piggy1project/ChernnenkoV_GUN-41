using System;

class Program
{
    static void Main()
    {
        // Ввод первого числа
        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error! Not a valid number.");
            return;
        }

        // Ввод второго числа
        Console.Write("Enter second number: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error! Not a valid number.");
            return;
        }

        // Ввод оператора
        Console.Write("Enter operator (&, |, ^): ");
        string op = Console.ReadLine();

        if (op != "&" && op != "|" && op != "^")
        {
            Console.WriteLine("Error! Invalid operator.");
            return;
        }

        // Вычисление результата
        int result = 0;
        switch (op)
        {
            case "&":
                result = a & b;
                break;
            case "|":
                result = a | b;
                break;
            case "^":
                result = a ^ b;
                break;
        }

        // Вывод результата в разных системах
        Console.WriteLine($"Decimal: {result}");
        Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Hexadecimal: {Convert.ToString(result, 16)}");
    }
}
