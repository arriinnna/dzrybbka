using System;

namespace VolumeCalculator_Overload
{
    class Volume
    {
        // Объем куба
        public double Calculate(double a)
        {
            return Math.Pow(a, 3);
        }

        // Объем прямоугольного параллелепипеда
        public double Calculate(double a, double b, double c)
        {
            return a * b * c;
        }

        // Объем цилиндра
        public double Calculate(double r, double h, bool isCylinder)
        {
            if (isCylinder)
                return Math.PI * Math.Pow(r, 2) * h;
            return 0;
        }

        // Объем шара
        public double Calculate(double r, bool isSphere)
        {
            if (isSphere)
                return (4.0 / 3) * Math.PI * Math.Pow(r, 3);
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Volume volume = new Volume();

            Console.WriteLine($"Объем куба со стороной 2 равен {volume.Calculate(2):F2}");
            Console.WriteLine($"Объем прямоугольного параллелепипеда 2x3x4 равен {volume.Calculate(2, 3, 4):F2}");
            Console.WriteLine($"Объем цилиндра с радиусом 3 и высотой 5 равен {volume.Calculate(3, 5, true):F2}");
            Console.WriteLine($"Объем шара с радиусом 3 равен {volume.Calculate(3, true):F2}");
        }
    }
}