using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class LibraryUser : Human
    {
        protected int IdReaderTicket;
        protected DateTime DateOfIssue;
        protected int SizeOfMonthCash;
        private static int currentIndex = 0;
        public LibraryUser()
        {

        }
        public LibraryUser (string firstName, string secondName, DateTime birthDate, int idReaderTicket, DateTime dateOfIssue, int sizeOfmonthCash) : base(firstName,secondName,birthDate)
        {
            SetIdReaderTicket(idReaderTicket);
            SetDateOfIssue(dateOfIssue);
            SetSizeOfMonthCash(sizeOfmonthCash);
        }
        public LibraryUser(Human human, int idReaderTicket, DateTime dateOfIssue, int sizeOfmonthCash) : base(human)
        {
            SetIdReaderTicket(idReaderTicket);
            SetDateOfIssue(dateOfIssue);
            SetSizeOfMonthCash(sizeOfmonthCash);
        }
        public LibraryUser(string firstName, string secondName, DateTime birthDate, int idReaderTicket, int sizeOfmonthCash) : this(firstName, secondName, birthDate,idReaderTicket, DateTime.Now,sizeOfmonthCash)
        {
        }
        public LibraryUser(Human human, int idReaderTicket, int sizeOfmonthCash) : this(human, idReaderTicket, DateTime.Now, sizeOfmonthCash)
        {
        }
        public int GetIdReaderTicket()
        {
            return IdReaderTicket;
        }
        public DateTime GetDateOfIssue()
        {
            return DateOfIssue;
        }
        public int GetSizeOfMonthCash()
        {
            return SizeOfMonthCash;
        }
        public void SetIdReaderTicket(int idReaderTicket)
        {
            IdReaderTicket = idReaderTicket;
        }
        public void SetDateOfIssue(DateTime dateOfIssue)
        {
            DateOfIssue = dateOfIssue;
        }
        public void SetSizeOfMonthCash(int sizeOfMonthCash)
        {
            SizeOfMonthCash = sizeOfMonthCash;
        }
        public static int GenerateId()
        {
            currentIndex++;
            return currentIndex;
        }
    }
}
