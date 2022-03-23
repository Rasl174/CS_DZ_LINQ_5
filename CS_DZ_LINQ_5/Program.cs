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
            List<CanStew> stewCans = new List<CanStew> { new CanStew("Орская", 2022, 2023), new CanStew("Настоящая", 2020, 2021),
            new CanStew("СОВЕТСКАЯ", 1930, 2354), new CanStew("Перекус с гречкой", 2021, 2021)};

            Console.WriteLine("Для вывода просрочи введите просрочка или 1");
            string userInput = Console.ReadLine();

            if(userInput == "просрочка" || userInput == "1")
            {
                Console.Clear();

                var overdueCans = stewCans.Where(can => can.ExpirationDate < 2022);

                foreach (var can in overdueCans)
                {
                    Console.WriteLine(can.Name + " произведена в " + can.ProductionYear + " годна до " + can.ExpirationDate);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введен не верный запрос!");
            }
        }
    }

    class CanStew
    {
        public string Name { get; private set; }

        public int ProductionYear { get; private set; }

        public int ExpirationDate { get; private set; }

        public CanStew (string name, int productionYear, int expirationDate)
        {
            Name = name;
            ProductionYear = productionYear;
            ExpirationDate = expirationDate;
        }
    }
}
