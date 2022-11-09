using System;
using System.Collections.Generic;

namespace EFUniversity
{

    public class Student
    {

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public override string ToString()
        {

            return "Id: " + Id + " LastName: " + LastName + " FirstName: " + FirstName;
        }
    }
}