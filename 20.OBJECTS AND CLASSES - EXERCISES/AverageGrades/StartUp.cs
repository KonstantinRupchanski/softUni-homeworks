using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    public class StartUp
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string name = input[0];

                double[] grades = input.Skip(1).Select(double.Parse).ToArray();


                students.Add(new Student(name, grades));


            }

            foreach (var student in students.Where(x => x.Average >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }

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