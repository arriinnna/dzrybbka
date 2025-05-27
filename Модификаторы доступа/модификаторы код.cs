using System;

namespace MyApp
{
    //Класс Car демонстрирует инкапсуляцию и различные модификаторы доступа
    public class Car
    {
        //private поля — недоступны извне
        private string make;
        private string model;

        //public свойство — доступно откуда угодно
        public int Year { get; set; }

        //internal метод — доступен только в пределах текущей сборки
        internal void SetMakeAndModel(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        //protected метод — доступен только в этом классе и унаследованных классах
        protected virtual void DisplayInfo()
        {
            Console.WriteLine($"Автомобиль: {make} {model}, Год: {Year}");
        }

        //public метод для вызова защищенного DisplayInfo извне
        public void ShowInfo()
        {
            DisplayInfo();
        }
    }

    //Класс ElectricCar наследует Car и добавляет собственное поведение
    public class ElectricCar : Car
    {
        //private поле — емкость батареи
        private double batteryCapacity;

        //public метод — установка значения батареи
        public void SetBatteryCapacity(double capacity)
        {
            batteryCapacity = capacity;
        }

        //protected override — переопределяет метод родителя и добавляет вывод батареи
        protected override void DisplayInfo()
        {
            base.DisplayInfo(); // вызывает родительский метод
            Console.WriteLine($"Емкость батареи: {batteryCapacity} кВт·ч");
        }

        //public метод для вызова защищенного DisplayInfo извне
        public new void ShowInfo()
        {
            DisplayInfo();
        }
    }

    //Главный класс с точкой входа
    class Program
    {
        static void Main()
        {
            //Создание экземпляра Car
            Car car = new Car();
            car.Year = 2020;

            //Попытка прямого доступа к make и model будет ошибкой — они private
            //car.make = "Toyota"; // Ошибка
            //car.model = "Corolla"; // Ошибка

            //Используем internal метод для установки
            car.SetMakeAndModel("Toyota", "Corolla");

            //Вывод информации
            car.ShowInfo();

            Console.WriteLine();

            //Создание экземпляра ElectricCar
            ElectricCar electricCar = new ElectricCar();
            electricCar.Year = 2023;
            electricCar.SetMakeAndModel("Tesla", "Model S");
            electricCar.SetBatteryCapacity(100.5);

            //Вывод информации
            electricCar.ShowInfo();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}