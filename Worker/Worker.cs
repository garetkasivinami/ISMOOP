using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Year;
        protected int Month;
        protected Company WorkPlace;
        public Worker()
        {

        }
        public Worker(string name, Company workPlace) : this(name, DateTime.Now.Year, DateTime.Now.Month, workPlace)
        {
            
        }
        public Worker(string name, int year, int month, Company workPlace)
        {
            SetCompany(workPlace);
            SetName(name);
            SetYear(year);
            SetMonth(month);
        }
        public Worker(Worker worker) : this(worker.Name, worker.Year,worker.Month, worker.WorkPlace)
        {

        }
        public string GetName()
        {
            return Name;
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public Company GetCompany()
        {
            return WorkPlace;
        }
        public void SetName(string name)
        {
            if (name.Length == 0)
            {
                throw new Exception("Name length is 0!");
            }
            Name = name;
        }
        public void SetYear(int year)
        {
            if (year > DateTime.Now.Year)
            {
                throw new Exception("Not correct Year!");
            }
            Year = year;
        }
        public void SetMonth(int month)
        {
            if (Year == DateTime.Now.Year && month > DateTime.Now.Month || month < 1 || month > 12)
            {
                throw new Exception("Non correct Month!");
            }
            Month = month;
        }
        public void SetCompany(Company company)
        {
            WorkPlace = company;
        }
        public int GetWorkExperience()
        {
            return (DateTime.Now.Year - Year - (DateTime.Now.Month < Month? 0: 1)) * 12 + (DateTime.Now.Month - Month);
        }
        public int GetTotalMoney()
        {
            return GetWorkExperience() * WorkPlace.GetSalary();
        }
        public override string ToString()
        {
            return $"{Name} працює з {Month} місяця {Year} року в компанії '{WorkPlace.GetName()}' на посаді '{WorkPlace.GetPosition()}' та отримує зарплатню {WorkPlace.GetSalary()} умовних одиниць";
        }
    }
}
