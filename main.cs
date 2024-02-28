using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваш вес в килограммах:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите ваш рост в метрах:");
        double height = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);
        Console.WriteLine("Ваш индекс массы тела (ИМТ) составляет: " + bmi.ToString("F2"));
        Console.WriteLine(GetBMICategory(bmi));
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    static string GetBMICategory(double bmi)
    {
        if (bmi < 16)
        {
            return "Выраженный дефицит массы тела";
        }
        else if (bmi >= 16 && bmi < 18.5)
        {
            return "Недостаточная масса тела";
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            return "Нормальная масса тела";
        }
        else if (bmi >= 25 && bmi < 30)
        {
            return "Избыточная масса тела";
        }
        else if (bmi >= 30 && bmi < 35)
        {
            return "Ожирение первой степени";
        }
        else if (bmi >= 35 && bmi < 40)
        {
            return "Ожирение второй степени";
        }
        else
        {
            return "Ожирение третьей степени";
        }
    }
}
