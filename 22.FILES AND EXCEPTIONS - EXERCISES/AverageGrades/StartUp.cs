using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AverageGrades
{
    public class StartUp
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("input.txt");

            List<Student> students = new List<Student>();
            while (!reader.EndOfStream)
            {

                int n = int.Parse(reader.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] input = reader.ReadLine().Split(' ').ToArray();

                    string name = input[0];

                    double[] grades = input.Skip(1).Select(double.Parse).ToArray();


                    students.Add(new Student(name, grades));


                }

                foreach (var student in students.Where(x => x.Average >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
                {
                    File.AppendAllText("output.txt", $"{student.Name} -> {student.Average:f2}\n");
                }
            }
        }
    }
}
