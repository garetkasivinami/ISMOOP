using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name;
        // це точно поле компанії?
        protected string Position;
        protected int Salary;
        public Company ()
        {

        }
        public Company(string name, string position, int salary)
        {
            SetName(name);
            SetPosition(position);
            SetSalary(salary);
        }
        public Company(Company company) : this(company.Name,company.Position, company.Salary)
        {

        }
        public Company(string name) : this(name, "null", 0)
        {

        }
        public string GetName ()
        {
            return Name;
        }
        public string GetPosition()
        {
            return Position;
        }
        public int GetSalary()
        {
            return Salary;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
    }
}
