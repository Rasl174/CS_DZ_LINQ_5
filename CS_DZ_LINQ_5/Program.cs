using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_LINQ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stew> stews = new List<Stew> { new Stew("Орская", 2022, 2023), new Stew("Настоящая", 2020, 2021),
            new Stew("СОВЕТСКАЯ", 1930, 2354), new Stew("Перекус с гречкой", 2021, 2021)};

            Console.WriteLine("Для вывода просрочи введите просрочка или 1");
            string userInput = Console.ReadLine();

            if(userInput == "просрочка" || userInput == "1")
            {
                Console.Clear();

                var overdue = stews.Where(stew => stew.ExpirationDate < 2022);

                foreach (var stew in overdue)
                {
                    Console.WriteLine(stew.Name + " произведена в " + stew.ProductionYear + " годна до " + stew.ExpirationDate);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введен не верный запрос!");
            }
        }
    }

    class Stew
    {
        public string Name { get; private set; }

        public int ProductionYear { get; private set; }

        public int ExpirationDate { get; private set; }

        public Stew (string name, int productionYear, int expirationDate)
        {
            Name = name;
            ProductionYear = productionYear;
            ExpirationDate = expirationDate;
        }
    }
}
