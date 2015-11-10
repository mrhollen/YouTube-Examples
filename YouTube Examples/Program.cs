using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_Examples
{
    class Program
    {
        Program()
        {
            Cat box = new Cat("Carl", "Gray Tabby", 10, 1.5);

            Console.WriteLine(box.GetInfo());

            box.Feed();

            Console.WriteLine(box.GetInfo());

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }

    public class Cat
    {
        public string name { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public double hunger { get; set; }

        public Cat(string name, string color, int age, double hunger)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.hunger = hunger;
        }

        public void Feed()
        {
            hunger = 0;
        }

        public string GetInfo()
        {
            return string.Format("Name: {0}\nColor: {1}\nAge: {2}\nHunger: {3}%", name, color, age, hunger * 100);
        }
    }
}
