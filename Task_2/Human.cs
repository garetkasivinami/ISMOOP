using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // краще ніж Person
    class Human
    {
        protected string FirstName;
        protected string SecondName;
        protected DateTime BirthDate;
        public Human() { }
        public Human(string firstName, string secondName, DateTime birthDate)
        {
            SetSecondName(secondName);
            SetFirstName(firstName);
            SetBirthDate(birthDate);
        }
        public Human(string firstName, string secondName) : this(firstName,secondName,DateTime.Now) { }
        public Human(Human human) : this(human.FirstName, human.SecondName, human.BirthDate)
        {

        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetSecondName()
        {
            return SecondName;
        }
        public DateTime GetBirthDate()
        {
            return BirthDate;
        }
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetSecondName(string secondName)
        {
            SecondName = secondName;
        }
        public void SetBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public string GetFullName()
        {
            return SecondName + " " + FirstName;
        }
        // дочірні класи можуть перевизначити
        public virtual string GetFullInfo()
        {
            return "Імя " + FirstName + ",фамілія " + SecondName + ", день народження " + BirthDate;
        }
    }
}
