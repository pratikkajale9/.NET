using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentQ1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Employee[] e = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the data of employee with id: {i}");
                e[i] = new Employee();
                e[i].GetEmployeeData();
            }
            for (int i = 0; i < 3; i++)
            {
                e[i].DisplayEmployee();
                

            }
            Console.WriteLine("==========================================");
            for (int i = 0; i < 3; i++)
            {
                e[i].HighSal(e1);
            }
            Console.WriteLine("==========================================");
       



            Console.WriteLine("================");
            Console.WriteLine("Enter ID of Employee To Be Search ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (EmpId == e[i].empId)
                {
                    Console.WriteLine("Employee found ");
                    e[i].DisplayEmployee();
                    
                }
            }
            
      

            Console.ReadLine();

        }

        

    }
    public class Employee
    {
        public int empId;
        public string name;
        public int salary;
        public string joiningDate;

        public Employee()
        {
                
        }
        public Employee(int empId ,string name, int salary, string joiningDate)
        {
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }

        public void GetEmployeeData()
        {
            {
                Console.WriteLine("Enter ID of Employee");
                empId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of employee: ");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the salary of employee: ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the date of joining of employee: ");
                joiningDate = Convert.ToString(Console.ReadLine());
            }
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("The ID of Employee is :"+empId);
            Console.WriteLine("The name of employee is: " + name);
            Console.WriteLine("The salary of employee is: " + salary);
            Console.WriteLine("The date of joining of employee is: " + joiningDate);
        }

        public void HighSal(Employee e)
        {

            int max = e.salary;
            for (int i = 0; i < 3; i++)
            {
                if (e.salary > max)
                {
                    max = e.salary;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (e.salary == max)
                {

                    Console.WriteLine("Maximum Salary of Employee Name is :" + e.name);
                    Console.WriteLine("And Salary is :" + e.salary);
                }
                break;

            }
        }
       
        

    } 

        
         
}



