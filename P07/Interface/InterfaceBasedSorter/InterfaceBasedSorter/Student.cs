using System;

namespace InterfaceBasedSorter
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

        public int CompareTo(ISortable other)
        {
            // compare by GPA ascending

            Student otherStudent = (Student)other;

            if (this.GPA < otherStudent.GPA)
                return -1;
            else if (this.GPA > otherStudent.GPA)
                return 1;
            else
                return 0;

        }

        public override string ToString()
        {
            return $"Student(Name: {Name}, GPA: {GPA})";
        }
    }
}
