
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedSorterDemo
{
    class Student : ISortable
    {
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(string name, double gpa)
        {
            Name = name;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"Student(Name: {Name}, GPA: {GPA})";
        }

        public int CompareTo(ISortable other)
        {
            Student otherStudent = (Student)other;

            /*
            if (this.GPA < otherStudent.GPA)
                return -1;
            else if (this.GPA > otherStudent.GPA)
                return 1;
            else
                return 0;
            */

            return this.Name.CompareTo(otherStudent.Name);
        }
    }
}
