using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Student[] e = new Student[3];
            Console.WriteLine("Enter the data of student");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter the name of Student: ");
                e[i].NAME = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the marks of student: ");
                e[i].MARKS = Convert.ToDecimal(Console.ReadLine());
                e[i] = new Student(e[i].NAME, e[i].MARKS);

            }
            for (int j = 0; j < 3; j++)
            {
                e[j].DisplayStudent();
            }
            Console.ReadLine();
        }
    }
    public struct Student
    {
        private int rollno;
        private string name;
        private decimal marks;
        private static int laststudent = 0;
        public int ROLLNO
        {
            private set
            {
                rollno = value;
            }
            get
            {
                return rollno;
            }
        }
        public string NAME
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name is empty");
                }
                else
                    name = value;
            }
            get
            {
                return name;
            }

        }
        
        public decimal MARKS
        {
            get
            {
                return marks;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    marks = value;
                else
                    Console.WriteLine("Enter valid marks");
            }
        }

        public Student(string name="noname",decimal marks=0)
        {
            rollno = ++laststudent;
            this.name = name;
            this.marks = marks;

        }
        public void DisplayStudent()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("The RollNo of Student is :" + rollno);
            Console.WriteLine("The name of student is: " + name);
            Console.WriteLine("The marks of employee is: " + marks);
            
        }

    }
}
