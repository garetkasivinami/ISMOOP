using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Abiturient : Human
    {
        protected string NameOfSchool;
        // дробові числа можуть мати похибку, під час розрахунків буде переведено в цілочисельний
        protected float AveragePointsOfEducation;
        protected ZnoCertificate[] ZnoCertificates;
        /// <summary>
        /// День народження повинен бути вказани обовязково
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="secondName"></param>
        /// <param name="birthDate"></param>
        /// <param name="nameOfSchool"></param>
        /// <param name="znoCertificates"></param>
        public Abiturient()
        {

        }
        public Abiturient(string firstName, string secondName, DateTime birthDate, float averagePointsOfEducation, string nameOfSchool, params ZnoCertificate[] znoCertificates) : base(firstName, secondName, birthDate)
        {
            SetAveragePointsOfEducation(averagePointsOfEducation);
            SetStandartStats(nameOfSchool,znoCertificates);
        }
        public Abiturient(string firstName, string secondName, DateTime birthDate,string nameOfSchool, params ZnoCertificate[] znoCertificates) : base(firstName, secondName, birthDate)
        {
            AveragePointsOfEducation = 1f;
            SetStandartStats(nameOfSchool, znoCertificates);
        }
        public Abiturient(Human human, float averagePointsOfEducation, string nameOfSchool, params ZnoCertificate[] znoCertificates) : base(human)
        {
            SetAveragePointsOfEducation(averagePointsOfEducation);
            SetStandartStats(nameOfSchool, znoCertificates);
        }
        public Abiturient(Human human, string nameOfSchool, params ZnoCertificate[] znoCertificates) : base(human)
        {
            AveragePointsOfEducation = 1f;
            SetStandartStats(nameOfSchool, znoCertificates);
        }
        private void SetStandartStats(string nameOfSchool, ZnoCertificate[] znoCertificates)
        {
            SetNameOfSchool(nameOfSchool);
            SetZnoCertificates(znoCertificates);
        }
        public string GetNameOfSchool()
        {
            return NameOfSchool;
        }
        /// <summary>
        /// Повертає середній бал атестата в форматі числа з комою
        /// </summary>
        /// <returns></returns>
        public float GetAveragePointsOfEducation()
        {
            return AveragePointsOfEducation;
        }
        /// <summary>
        /// Повертає середній бал атестата в форматі цілого числа помноженого на 100
        /// </summary>
        /// <returns></returns>
        public int GetAveragePointsOfEducationInt()
        {
            return (int)(AveragePointsOfEducation * 100);
        }
        public void SetAveragePointsOfEducation(float averagePointsOfEducation)
        {
            AveragePointsOfEducation = averagePointsOfEducation;
        }
        /// <summary>
        /// Середній бал атестата має бути помножений на 100 для цілих чисел
        /// </summary>
        /// <param name="averagePointsOfEducation"></param>
        public void SetAveragePointsOfEducationInt(int averagePointsOfEducation)
        {
            AveragePointsOfEducation = averagePointsOfEducation / 100f;
        }
        public ZnoCertificate[] GetZnoCertificates()
        {
            return ZnoCertificates;
        }
        public ZnoCertificate GetZnoCertificate(int index)
        {
            if (index < 0 || index >= ZnoCertificates.Length)
            {
                throw new Exception("The index is outside the array");
            }
            return ZnoCertificates[index];
        }
        public ZnoCertificate GetZnoCertificate(string znoName, int year)
        {
            for (int i = 0; i < ZnoCertificates.Length; i++)
            {
                if (ZnoCertificates[i].CompareTo(year, znoName))
                {
                    return ZnoCertificates[i];
                }
            }
            throw new Exception("Dont have ZNO certificate!");
        }
        public int GetZnoCertificateLength()
        {
            return ZnoCertificates.Length;
        }
        public void SetNameOfSchool(string nameOfSchool)
        {
            NameOfSchool = nameOfSchool;
        }
        public void SetZnoCertificates(params ZnoCertificate[] znoCertificates)
        {
            ZnoCertificates = znoCertificates;
        }
        /*
        private string GetZnoToStr()
        {
            string result = "";
            for (int i = 0; i < ZnoCertificates.Length; i++)
            {
                result += ZnoCertificates[i].ToString();
                if (i < ZnoCertificates.Length - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }
        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $", навчається в {NameOfSchool} та має такі результати зно: {GetZnoToStr()}";
        }
        */
    }
}
