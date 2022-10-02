using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Input();
            AllSegment(r);

            Console.WriteLine("Введите параметр x");
            double x = Input();

            CheсkFunction(x, r);
        }

        static double Input() //ввод переменной 
        {
            string temp;
            double a;
            do
            {
                
                temp = Console.ReadLine();
                if (double.TryParse(temp, out a)) //проверка на ввод
                {
                    break;
                }
                Console.Write("Ошибка введите значение переменной нормально ");
            }
            while (true);
            return a;
        }

        static double FirstSegment(double x)//первый сегмент
        {
            double y = -3;
            Console.WriteLine($"Значение функции при x = {x}    : {y}");
            return y;
        }
        static double SecondSegment(double x)//второй сегмент
        {
            double y = Math.Round((x + 3), 3);
            Console.WriteLine($"Значение функции при x = {x}        : {y}");
            return y;
        }
        static double ThirdSegment(double x, double R)//третий сегмент
        {
            
            if (R * R - Math.Pow(x , 2) >= 0)
            {
                double y = Math.Round(Math.Sqrt(R * R - Math.Pow(x , 2)), 3);
                Console.WriteLine($"Значение функции при x = {x}        : {y}");
                return y;
            }
            else
            {
                if (x == -3 || x == 3)// проверка на точки
                {
                    return 0;
                };
                Console.WriteLine($"Функция неопределена при х= {x}");
                return 0;
            }
        }

        static double FourthSegment(double x)
        {
            double y = Math.Round((0.6 * x - 1.2), 3);
            Console.WriteLine($"Значение функции при x = {x}        : {y}");
            return y;
        }
        static double FivethSegment(double x)
        {
            double y = 3;
            Console.WriteLine($"Значение функции при x = {x}        : {y}");
            return y;
        }

        static void CheсkFunction(double x, double R)
        {
            if (x > -8 && x <= -4)
            {
                FirstSegment(x);
            };
            if (-4 <= x && x <= -3)
            {

                SecondSegment(x);
            };
            if (-3 < x && x <= 3)
            {
                ThirdSegment(x, R);
            };
            if (3 < x && x <= 8)
            {
                FourthSegment(x);
            };
            if (x > 8 && x <= 10)
            {
                FivethSegment(x);
            };
            if (x < -8 || x > 10)
            {
                Console.WriteLine("x не принадлежит[-8, 10]");
            };


        }
       
        static void AllSegment(double r)//выдача значений с шагом 0,2
        {
            for (double x = -8; x <= 10; x += 0.2)
            {
                CheсkFunction(Math.Round(x, 2), r);
            }

        }
    }
}
