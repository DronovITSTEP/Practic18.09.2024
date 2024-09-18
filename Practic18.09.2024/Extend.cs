using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic18._09._2024
{
    abstract class Human
    {
        private int _id;
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        protected string _surname = "Иванов";      

        public Human(string name, string date) {
            Name = name;
            BirthDay = DateTime.Parse(date);
        }
        public abstract void Print();
    }

    class Employee : Human
    {
        public Employee(string name, string date,
            int salary, string pos) : base(name, date)
        {
            Salary = salary;
            Position = pos;
        }
        public Employee(string name, string date): this(name, date, 0, null){}
        public int Salary { get; set; }
        public string Position { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"{Salary}, {Position}, {Name} {_surname}");
        }

        public override void Print() {         
           Console.WriteLine($"{Salary}, {Position}");
        }
    }
    sealed class Storekeeper : Employee
    {
        public Storekeeper(string name, string date, int salary, string pos)
            : base(name, date, salary, pos)
        {
        }
        public void ShowStore()
        {
            Console.WriteLine("Складирую товар");
        }
        public string Description { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($" описание должности");
        }
        /// <returns>string</returns>
        private string PrintNewMethod()
        {
            return $"{Name + " " + BirthDay.ToLongDateString()}\n" +
                $"{Salary}, {Position}\n" +
                $"описание должности";
        }
        public override string ToString()
        {
            return $"{Name + " " + BirthDay.ToLongDateString()}\n" +
                $"{Salary}, {Position}\n" +
                $"описание должности";
        }

    }
    class Cashier : Employee
    {
        public Cashier(string name, string date, int salary, string pos)
            : base(name, date, salary, pos)
        {
        }
        public void ShowKassa()
        {
            Console.WriteLine("Пробиваю товар");
        }
        public string Description { get; set; }

    }
    class Saler : Employee
    {
        public Saler(string name, string date, int salary, string pos)
            : base(name, date, salary, pos)
        {
        }
        public void ShowSale()
        {
            Console.WriteLine("Продаю товар");
        }
        public string Description { get; set; }

    }

    /*    class Test : Storekeeper // нельзя унаследоваться, т.к. Storekeeper имеет sealed
        {
            public Test(string name, string date, int salary, string pos) : base(name, date, salary, pos)
            {
            }
        }*/

    /*abstract class AbstractClass
    {
        public string Name { get; set; }
        private int number;

        public void Show()
        {
            Console.WriteLine("Метод абстрактного класса");
        }
        //public abstract void Print();
    }*/
}
