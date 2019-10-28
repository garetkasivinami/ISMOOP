using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Teacher : HiEducationPerson
    {
        protected string Position;
        protected string Chair;
        public Teacher()
        {

        }
        public Teacher(string firstName, string secondName, DateTime birthDate, string position, string chair, string nameOfInstitution) : base(firstName, secondName, birthDate, nameOfInstitution)
        {
            SetChair(chair);
            SetPosition(position);
        }
        public Teacher(Human human, string position, string chair, string nameOfInstitution) : base(human, nameOfInstitution)
        {
            SetChair(chair);
            SetPosition(position);
        }
        public string GetChair()
        {
            return Chair;
        }
        public string GetPosition()
        {
            return Position;
        }
        public void SetChair(string chair)
        {
            Chair = chair;
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
    }
}
