using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car(123321, "BMW", "7-serios", 2002, "black", 17000, 1111);
            Car Car2 = new Car(123321, "7-serios", "BMW", 2002, 1111);
            Car Car3 = new Car();
            Console.WriteLine("Car1.ToString() = " + Car1.ToString());
            Console.WriteLine("Car2.Equals(Car1) = " + Car2.Equals(Car1));
            Console.WriteLine("Car3.GetHashCode() = " + Car3.GetHashCode());

            Console.WriteLine("Сколько автомобилей?");
            int avto = Convert.ToInt32(Console.ReadLine());
            Car[] Car = new Car[avto];

            for (int i = 0; i < avto; i++)
            {
                Console.WriteLine($"Данные об авто №{i+1}");
                Car[i] = new Car();
                Car[i].numofCar = i + 1;
                Console.WriteLine("Серийный код:");
                Car[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Марка авто:");
                Car[i].marka = Console.ReadLine();
                Console.WriteLine("Модель авто");
                Car[i].Model = Console.ReadLine();
                Console.WriteLine("Год авто:");
                Car[i].god = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Цвет авто:");
                Car[i].color = Console.ReadLine();
                Console.WriteLine("Ценв авто:");
                Car[i].cena = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Регистрационный номер авто:");
                Car[i].registr = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Поиск по марке авто:");
            string markaSearch = Console.ReadLine();
            foreach(Car Carsearch in Car)
            {
                if(Carsearch.marka == markaSearch)
                {
                    Console.WriteLine($"Серийный код:{Carsearch.Id}");
                    Console.WriteLine($"Модель:{Carsearch.Model}");
                    Console.WriteLine($"Год:{Carsearch.god}");
                    Console.WriteLine($"Цена:{Carsearch.cena}");
                    Console.WriteLine($"Цвет:{Carsearch.color}");
                    Console.WriteLine($"Регистрация: {Carsearch.registr}");
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Поиск по модели авто:");
            string modelSearch = Console.ReadLine();
            foreach(Car Carsearh in Car)
            {
                if(Carsearh.Model == modelSearch)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Серийный код:{Carsearh.Id}");
                    Console.WriteLine($"Марка:{Carsearh.marka}");
                    Console.WriteLine($"Год:{Carsearh.god}");
                    Console.WriteLine($"Цена:{Carsearh.cena}");
                    Console.WriteLine($"Цвет:{Carsearh.color}");
                    Console.WriteLine($"Регистрация:{Carsearh.registr}");

                }
            }
        }
    }

    public partial class Car
    {
        private int id;
        private string Marka;
        private string model;
        private int God;
        private string Color;
        private int Cena;
        private int Registr;
        public int prodano = 100;
        public int noProdano = 0;
        private int kolichestvo = 100;
        public int numofCar = 0;



        public Car()
        {
            numofCar++;

        }

        public Car(int id, string marka, string model, int God, string Color, int Cena, int Registr)
        {
            numofCar++;
            this.id = id;
            this.Marka = marka;
            this.model = model;
            this.God = God;
            this.Color = Color;
            this.Cena = Cena;
            this.Registr = Registr;
        }

        public Car(int id, string model, string Color, int Cena, int Registr, string Marka = "BMW", int God = 2002)
        {
            numofCar++;
            this.id = id;
            this.Marka = Marka;
            this.model = model;
            this.God = God;
            this.Color = Color;
            this.Cena = Cena;
            this.Registr = Registr;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string marka
        {
            get
            {
                return Marka;
            }
            set
            {
                Marka = value;
            }
        }
        public string color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }
        public int cena
        {
            get
            {
                return Cena;
            }
            set
            {
                Cena = value;
            }
        }
        public int god
        {
            get
            {
                return God;
            }
            set
            {
                God = value;
            }
        }
        public int registr
        {
            get
            {
                return Registr;
            }
            set
            {
                Registr = value;
            }
        }
         public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Noprodano
        {
            get
            {
                return noProdano;
            }
            set
            {
                noProdano = value;
            }
        }
        
    }
}
    