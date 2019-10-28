using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ZnoCertificate
    {
        protected string NameOfSubject;
        protected int Year;
        // дробові числа можуть мати похибку, під час розрахунків буде переведено в цілочисельний
        protected float Result;
        public ZnoCertificate(string nameOfSubject, int year, float result)
        {
            SetNameOfSubject(nameOfSubject);
            SetYear(year);
            SetResult(result);
        }
        /// <summary>
        /// Цілочисельний конструктор, result має бути в форматі результат ЗНО * 100
        /// </summary>
        /// <param name="nameOfSubject"></param>
        /// <param name="year"></param>
        /// <param name="result"></param>
        public ZnoCertificate(string nameOfSubject, int year, int result)
        {
            SetNameOfSubject(nameOfSubject);
            SetYear(year);
            SetResultInt(result);
        }
        public ZnoCertificate(ZnoCertificate znoCertificate) : this(znoCertificate.NameOfSubject,znoCertificate.Year, znoCertificate.Result)
        {

        }
        /// <summary>
        /// Повертає результат ЗНО в форматі числа з комою
        /// </summary>
        /// <returns></returns>
        public float GetResult()
        {
            return Result;
        }
        /// <summary>
        /// Повертає результат перетворений до цілого числа помноженого на 100
        /// </summary>
        /// <returns></returns>
        public int GetIntResult()
        {
            return (int)(Result * 100);
        }
        public string GetNameOfSubject()
        {
            return NameOfSubject;
        }
        public void SetNameOfSubject(string nameOfSubject)
        {
            NameOfSubject = nameOfSubject;
        }
        public void SetResult(float result)
        {
            Result = result;
        }
        /// <summary>
        /// result результат ЗНО має бути помножений на 100
        /// </summary>
        /// <param name="result"></param>
        public void SetResultInt(int result)
        {
            Result = result / 100f;
        }
        public string GetStateOfZno()
        {
            if (Result < 100)
            {
                return "не склав";
            } else
            {
                return Result.ToString();
            }
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public bool CompareTo(int year, string subjectName)
        {
            if (Year == year && NameOfSubject == subjectName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{((Result < 100)? "Не": "С")}клав(ла) {NameOfSubject} {((Result < 100)? "" :"на" + GetStateOfZno())} в {Year} році";
        }
    }
}
