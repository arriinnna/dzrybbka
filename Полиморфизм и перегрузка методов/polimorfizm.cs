namespace VolumeCalculator_Polymorphism
{
    abstract class Shape
    {
        public abstract double CalculateVolume();
    }

    class Cube : Shape
    {
        public double Side { get; set; }

        public Cube(double side)
        {
            Side = side;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(Side, 3);
        }
    }

    class RectangularPrism : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public RectangularPrism(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateVolume()
        {
            return A * B * C;
        }
    }

    class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }

    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape cube = new Cube(2);
            Shape prism = new RectangularPrism(2, 3, 4);
            Shape cylinder = new Cylinder(3, 5);
            Shape sphere = new Sphere(3);

            Console.WriteLine($"Объем куба со стороной 2 равен {cube.CalculateVolume():F2}");
            Console.WriteLine($"Объем прямоугольного параллелепипеда 2x3x4 равен {prism.CalculateVolume():F2}");
            Console.WriteLine($"Объем цилиндра с радиусом 3 и высотой 5 равен {cylinder.CalculateVolume():F2}");
            Console.WriteLine($"Объем шара с радиусом 3 равен {sphere.CalculateVolume():F2}");
        }
    }
}