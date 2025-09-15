using System;
using System.Collections.Generic;

namespace StudentPerformanceAnalyzer
{
    internal class Program
    {
        class Student
        {
            public string name;
            public int age;
            public int marks;
            public int? extraMarks;
            public bool isActive;
            public int totalMarks;
            public double percentage;
            public char studentGrade;

            public char StudentGrade(int totalMarks)
            {
                if(totalMarks >= 90)
                {
                    studentGrade = 'A';
                }
                else if (totalMarks >= 70 && totalMarks <= 89)
                {
                    studentGrade = 'B';
                }
                else if (totalMarks >= 50 && totalMarks <= 69)
                {
                    studentGrade = 'C';
                }
                else if (totalMarks >= 40 && totalMarks <= 59)
                {
                    studentGrade = 'D';
                }
                else
                {
                    studentGrade = 'F';
                }
                return studentGrade;
            }
        }
        static void Main(string[] args)
        {

            Console.Write("How many student details you want to enter: ");
            bool studCountInputSucc = int.TryParse(Console.ReadLine(), out int studCount);
            if (!studCountInputSucc) { Console.WriteLine("Invalid input"); return; }

            List<Student> students = new List<Student>();

            for (int i = 0; i < studCount; i++)
            {
                Student student = new Student();

                Console.Write("Enter students name: ");
                student.name = Console.ReadLine();

                Console.Write("Enter students age: ");
                bool studAgeSucc = int.TryParse(Console.ReadLine(), out student.age);
                if (!studAgeSucc) { Console.WriteLine("Invalid input"); return; }

                Console.Write("Enter students marks: ");
                bool studMarksSucc = int.TryParse(Console.ReadLine(), out student.marks);
                if (!studMarksSucc) { Console.WriteLine("Invalid input"); return; }

                Console.Write("Enter students extra marks: ");
                string extraMark = Console.ReadLine();
                student.extraMarks = string.IsNullOrWhiteSpace(extraMark)
                                ? (int?)null
                                : (int.TryParse(extraMark, out int parsed)
                                    ? parsed
                                    : (int?)null);

                Console.Write("Is the student active/regular(true/false): ");
                bool studIsActiveSucc = bool.TryParse(Console.ReadLine(), out student.isActive);
                if (!studIsActiveSucc) { Console.WriteLine("Invalid input"); return; }

                student.totalMarks = student.marks + (student.extraMarks ?? 0);

                student.percentage = (student.totalMarks / 100.00) * 100;

                student.StudentGrade(student.totalMarks);

                students.Add(student);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("| {0,-10} | {1,-5} | {2,-6} | {3,-6} | {4,-6} | {5,-10} | {6,-6} | {7,-6} |",
                "Name", "Age", "Marks", "Extra", "Total", "Percentage", "Grade", "Active");
            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Student student in students)
            {
                string marksExtra = student.extraMarks?.ToString() ?? "N/A";
                Console.WriteLine("| {0,-10} | {1,-5} | {2,-6} | {3,-6} | {4,-6} | {5,-10:F2} | {6,-6} | {7,-6} |",
                    student.name, student.age, student.marks, marksExtra, student.totalMarks, student.percentage, student.studentGrade, student.isActive);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
