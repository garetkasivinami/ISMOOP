using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class HiEducationPerson : Human
    {
        public HiEducationPerson()
        {

        }
        protected string NameOfInstitution;
        public HiEducationPerson(string firstName, string secondName, DateTime birthDate, string nameOfInstitution) : base(firstName,secondName,birthDate)
        {
            SetNameOfInstitution(nameOfInstitution);
        }
        public HiEducationPerson(Human human, string nameOfInstitution) : base(human)
        {
            SetNameOfInstitution(nameOfInstitution);
        }
        public string GetNameOfInstitution()
        {
            return NameOfInstitution;
        }
        public void SetNameOfInstitution(string nameOfInstitution)
        {
            NameOfInstitution = nameOfInstitution;
        }
    }
}
