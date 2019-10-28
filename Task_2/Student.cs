using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student : HiEducationPerson
    {
        protected string Group;
        protected string Cource;
        protected string Faculty;
        public Student()
        {

        }
        public Student(string firstName, string secondName, DateTime birthDate, string group, string course, string faculty, string nameOfInstitution) : base(firstName,secondName,birthDate, nameOfInstitution)
        {
            SetGroup(group);
            SetCource(course);
            SetFaculty(faculty);
        }
        public Student(Human human, string group, string course, string faculty, string nameOfInstitution) : base(human, nameOfInstitution)
        {
            SetGroup(group);
            SetCource(course);
            SetFaculty(faculty);
        }
        public string GetGroup()
        {
            return Group;
        }
        public string GetCource()
        {
            return Cource;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public void SetGroup(string group)
        {
            Group = group;
        }
        public void SetCource(string cource)
        {
            Cource = cource;
        }
        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }
    }
}
