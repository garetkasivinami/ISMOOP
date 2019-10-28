using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        public static readonly Random random = new Random();
        public static readonly string[] FirstNames = {"Антон", "Аркадій", "Генадій", "Вадим", "Олександр", "Михайло", "Кирил"};
        public static readonly string[] SecondNames = {"Грабець", "Мельник", "Глищук", "Заєць", "Кучинський"};
        private static Company[] Companies; 
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //Companies = new Company[]{ new Company("Житомир технік", "Водій", 15000), new Company("Автодор", "Технік", 15000), new Company("Житомир таксі", "Водій", 18750), new Company("Глобал", "Технічий персонал", 1540) };
            CreateCompanies();
            //Worker[] workers = GenerateRandomWorkers(Companies, 10);
            Worker[] workers = createWorkers();
            while (true)
            {
                Console.WriteLine("Оберіть наступний шлях роботи програми:");
                Console.WriteLine("1 - написати список робочих");
                Console.WriteLine("2 - сортування робочих з  зарплатнею");
                Console.WriteLine("3 - сортування робочих за робочим стажем");
                Console.WriteLine("4 - написати список компаній");
                Console.WriteLine("0 - вихід");
                switch(Console.ReadLine()) {
                    case "0":
                        return;
                    case "1":
                        PrintWorkers(workers);
                        break;
                    case "2":
                        SortWorkerBySalary(workers);
                        break;
                    case "3":
                        SortWorkerByWorkExperience(workers);
                        break;
                    case "4":
                        PrintCompanies();
                        break;
                    default:
                        Console.WriteLine("Невідома команда");
                        break;
                }
            }
        }
        public static Worker[] createWorkers()
        {
            Console.WriteLine("Напишіть кількість працівників");
            Worker[] workers = new Worker[int.Parse(Console.ReadLine())];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();
                Console.WriteLine("Напишіть імя працівника");
                workers[i].SetName(Console.ReadLine());
                Console.WriteLine("Напишіть рік початку роботи працівника");
                workers[i].SetYear(int.Parse(Console.ReadLine()));
                Console.WriteLine("Напишіть місяць початку роботи працівника");
                workers[i].SetMonth(int.Parse(Console.ReadLine()));
                PrintCompanies();
                Console.WriteLine("Напишіть індекс компанії працівника");
                workers[i].SetCompany(Companies[int.Parse(Console.ReadLine())]);
                Console.WriteLine("-------------------");
            }
            return workers;
        }
        public static void CreateCompanies()
        {
            Console.WriteLine("Напишіть кількість компаній");
            Companies = new Company[int.Parse(Console.ReadLine())];
            for (int i = 0; i < Companies.Length; i++)
            {
                Companies[i] = new Company();
                Console.WriteLine("Напишіть ім'я компанії");
                Companies[i].SetName(Console.ReadLine());
                Console.WriteLine("Напишіть посаду");
                Companies[i].SetPosition(Console.ReadLine());
                Console.WriteLine("Напишіть зарплатню (ціле число)");
                Companies[i].SetSalary(int.Parse(Console.ReadLine()));
                Console.WriteLine("-------------------");
            }
        }
        private static void PrintCompanies()
        {
            for (int i = 0; i < Companies.Length; i++)
            {
                Console.WriteLine($"{i}-{Companies[i].GetName()} {Companies[i].GetPosition()} {Companies[i].GetSalary()}");
            }
        }
        public static Worker[] GenerateRandomWorkers(Company[] companies, int length)
        {
            Worker[] workers = new Worker[length];
            for (int i = 0; i < length; i++)
            {
                workers[i] = GenerateRandomWorker(companies[random.Next(0,companies.Length)]);
            }
            return workers;
        }
        public static Worker GenerateRandomWorker(Company company)
        {
            return new Worker(FirstNames[random.Next(0,FirstNames.Length)] + " " + SecondNames[random.Next(0, SecondNames.Length)],random.Next(1990,DateTime.Now.Year), random.Next(1,13), company);
        }
        public static void PrintWorker(Worker worker)
        {
            Console.WriteLine(worker.ToString());
        }
        public static void PrintWorkers(params Worker[] worker)
        {
            for (int i = 0; i < worker.Length; i++)
            {
                PrintWorker(worker[i]);
            }
        }
        private static int newGap(int _gap)
        {
            _gap = (int)(_gap / 1.3);

            if (_gap == 9 || _gap == 10)
                _gap = 11;
            if (_gap < 1)
                return 1;

            return _gap;
        }
        public static Worker[] SortWorkerBySalary(Worker[] mass)
        {
            Worker worker;
            int flag = 1;
            int gap = mass.Length;
            while (flag != 0 || gap > 1)
            {
                flag = 0;
                gap = newGap(gap);
                for (int i = 0; i < mass.Length - gap; i++)
                {
                    if (mass[i + gap].GetCompany().GetSalary() < mass[i].GetCompany().GetSalary())
                    {
                        worker = mass[i + gap];
                        mass[i + gap] = mass[i];
                        mass[i] = worker;
                        flag = 1;
                    }
                }
            }
            return mass;
        }
        public static Worker[] SortWorkerByWorkExperience(Worker[] mass)
        {
            Worker worker;
            int flag = 1;
            int gap = mass.Length;
            while (flag != 0 || gap > 1)
            {
                flag = 0;
                gap = newGap(gap);
                for (int i = 0; i < mass.Length - gap; i++)
                {
                    if (mass[i + gap].GetWorkExperience() > mass[i].GetWorkExperience())
                    {
                        worker = mass[i + gap];
                        mass[i + gap] = mass[i];
                        mass[i] = worker;
                        flag = 1;
                    }
                }
            }
            return mass;
        }
    }
}
