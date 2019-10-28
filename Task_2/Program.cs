using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //
            List<Human> humans = new List<Human>();
            List<HiEducationPerson> hiEducationPeoples = new List<HiEducationPerson>();
            List<LibraryUser> libraryUsers = new List<LibraryUser>();
            humans.Add(new Human("Антон","Циган"));
            Human secondPerson = new Human(humans[0]);
            secondPerson.SetBirthDate(new DateTime(1990,02,15));
            secondPerson.SetFirstName("Руслан");
            HiEducationPerson hiEducationPeople = new Student("Анатолій", "Залийвода", new DateTime(2000, 12, 31), "КБ-2-1", "Курс", "Інформаційно-компютрених технологій", "КПІ");
            hiEducationPeoples.Add(hiEducationPeople);
            humans.Add(hiEducationPeople);
            // створюємо новий екземпляр та змінюємо посилання
            hiEducationPeople = new Teacher("Мстислав", "Деонізович", new DateTime(1980,10,3),"Проффесор!","Проффесорські академічні науки", "Житомирський проффесорський університет");
            Teacher teacher = (Teacher) hiEducationPeople; // downcast
            teacher.SetPosition("Вчений");
            hiEducationPeoples.Add(hiEducationPeople);
            humans.Add(hiEducationPeople);
            LibraryUser libraryUser = new LibraryUser("Вічноживий", "Власович",new DateTime(1955,4,15),LibraryUser.GenerateId(),200);
            libraryUsers.Add(libraryUser);
            humans.Add(libraryUser);
            Abiturient abiturient = new Abiturient("Ігнатій", "Сумний", new DateTime(2002,8,26), 10.5f,"Половецька школа 1-3 ступенів", new ZnoCertificate("Українська мова",2019,185), new ZnoCertificate("Математика",2019, 195), new ZnoCertificate("Фізика", 2019, 197.3f));
            humans.Add(abiturient);
            ZnoCertificate znoCertificate = abiturient.GetZnoCertificate("Математика", 2019);
            // створюємо новий екземпляр та змінюємо посилання
            abiturient = new Abiturient("Михайло", "Лінивий",new DateTime(2000,10,4),6.3f,"Бердичівська школа №6",new ZnoCertificate("Українська мова",2018,135f), new ZnoCertificate(znoCertificate), new ZnoCertificate("Історія",2017, 149f));
            PrintMassive(GetNames(humans.ToArray()));
            PrintMassive(GetFullInfo(humans.ToArray()));
            Console.ReadKey();
        }
        static string[] GetFullInfo(Human[] humans)
        {
            string[] result = new string[humans.Length];
            for (int i = 0; i < humans.Length; i++)
            {
                result[i] = humans[i].GetFullInfo();
            }
            return result;
        }
        static string[] GetNames(Human[] humans)
        {
            string[] result = new string[humans.Length];
            for (int i = 0; i < humans.Length; i++)
            {
                result[i] = humans[i].GetFullName();
            }
            return result;
        }
        static DateTime[] GetBirthDates(Human[] humans)
        {
            DateTime[] result = new DateTime[humans.Length];
            for (int i = 0; i < humans.Length; i++)
            {
                result[i] = humans[i].GetBirthDate();
            }
            return result;
        }
        static void PrintMassive<T>(T[] mass)
        {
            string result = "{";
            for (int i = 0; i < mass.Length; i++)
            {
                result += mass[i].ToString();
                if (i < mass.Length - 1)
                {
                    result += ", ";
                }
            }
            result += "}";
            Console.WriteLine(result);
        }
        static void PrintMassive(string[] mass)
        {
            string result = "{\n";
            for (int i = 0; i < mass.Length; i++)
            {
                result += mass[i] + "\n";
            }
            result += "}";
            Console.WriteLine(result);
        }
    }
}
