using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Models
{
    public class Applicant
    {
        public int SchoolNumber { get; }
        public string LastName { get; }
        public int YearOfEntry { get; }

        public Applicant(int num, int year, string lastName)
        {
            SchoolNumber = num;
            LastName = lastName;
            YearOfEntry = year;
        }
    }
}
