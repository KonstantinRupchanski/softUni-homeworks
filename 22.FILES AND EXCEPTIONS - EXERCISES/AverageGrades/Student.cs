using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average { get { return Grades.Average(); } }

        public Student(string name, IEnumerable<double> grades)
        {
            this.Name = name;
            this.Grades = new List<double>(grades);
        }
    }
}
