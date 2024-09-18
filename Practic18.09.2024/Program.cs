using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic18._09._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee storekeeper = new Storekeeper(
                "Александр",
                "07.03.1960",
                56000,
                "storekeeper");
            /*Employee[] employee =
            {
                new Cashier ("Кассир", "01-01-01", 45000, "cashier"),
                new Saler ("Продавец", "06 12 1900", 45000, "saler"),
                storekeeper
            };

            foreach (Employee emp in employee)
            {
                emp.Show();
                // 1 способ
                try
                {
                    ((Storekeeper)emp).ShowStore();
                }
                catch { }

                // 2 способ
                Cashier cashier = emp as Cashier;
                if (cashier != null)
                {
                    cashier.ShowKassa();
                }

                // 3 способ
                if (emp is Saler)
                {
                    (emp as Saler).ShowSale();
                }
            }*/

            //storekeeper.Print();

            //Console.WriteLine((Storekeeper)storekeeper).Print2());
            Console.WriteLine(storekeeper);

            Employee human = new Storekeeper("Александр",
                "07.03.1960",
                56000,
                "storekeeper");

            /*
            Создать класс Животное (+ если класс будет абстрактным),
            Создать дочерние классы: Кот, Собака
            В main создать экземпляр класса Животное и передать 
            ссылки на дочерние классы
             */

        }
    }
}
