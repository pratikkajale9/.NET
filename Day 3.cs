using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           // Manager m = new Manager("ceo","anjali",2,1500);
            // Manager m1 = new Manager("ceo", "anj", 3, 2500);
            Console.WriteLine("======");
            GenralManger m1 = new GenralManger("sir","ceo", "anjali", 2, 2500);
            Console.ReadLine();


            Employee e = new Manager("Manager", "mgr", 1,53000);
            Console.WriteLine("Empid: " + e.EMPNO + ", Name: " + e.NAME + ", Basic salary: " + e.BASIC + ", Dept No: " + e.DEPTNO);
            Console.ReadLine();
            /*
            Manager m = new GenralManger("GM", "",25000);
            Console.WriteLine("Empid: " + m.EMPNO + ", Name: " + m.NAME + ", Basic salary: " + m.BASIC);
            Console.ReadLine();
            */
            Employee ceo = new CEO("", 200000);
            Console.WriteLine("Empid: " + ceo.EMPNO + ", Name: " + ceo.NAME + ", Basic salary: " + ceo.BASIC + ", Net salary: " + ceo.CalNetSalary());
            Console.ReadLine();

            Employee ceo1 = new CEO("CEO", 1000);
            Console.WriteLine("Empid: " + ceo1.EMPNO + ", Name: " + ceo1.NAME + ", Basic salary: " + ceo1.BASIC + ", Net salary: " + ceo1.CalNetSalary());
            Console.ReadLine();
        }
    }
}
public abstract class Employee
{
    //property
    private string name;
    private int empno;
    private short deptno;
    protected decimal basic;

    private static int lastempno = 0;
    public int EMPNO 
    {
        get
        {
            return empno;
        }
        private set
        {
            empno = value;

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
    public abstract  decimal BASIC
    {
        set;
        get;
        
    }
    
    public short DEPTNO
    {
        set
        {
            if (value > 0)
                deptno = value;
            else
                Console.WriteLine("Deptartment number is not valid");
        }
        get
        {
            return deptno;
        }
    }



    public Employee(string name="noname",short deptno=1,decimal basic=1000)
    {
        empno = ++lastempno;
        this.name = name;
        this.deptno = deptno;
        this.basic = basic;


    }

    public abstract decimal CalNetSalary();

}
public class Manager : Employee
{
   // decimal hra = 100;
    private string designation;
    public string DESIGNATION
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("designation cant be blank ");
            }
            else
                designation = value;
        }
        get
        {
            return designation;
        }
    }
    //ctor
    public Manager(string designation = "sir", string name = "noname", short deptno=1, decimal basic=1000) : base(name,deptno,basic)
    {
        this.designation = designation;
        
     }
   
    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 50000 && value <= 150000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }

    }

   

    public override decimal CalNetSalary()
    {
        if (BASIC >= 50000 && BASIC <= 150000)
        {
            decimal netSal = BASIC + 5000;
            return netSal;
        }
        return BASIC;
    }
}
public class GenralManger : Manager
{
    private string Perks;

    public GenralManger(string Perks = "perksir",string designation="ceo", string name = "noname", short deptno = 1, decimal basic = 1000) : base(designation,name,deptno,basic)
    {
       this.Perks = Perks;
    }
    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 100000 && value <= 250000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }
    }
    public override sealed decimal CalNetSalary()
    {
        if (BASIC >= 150000 && BASIC <= 350000)
        {
            decimal netSal = BASIC + 15000;
            return netSal;
        }
        return BASIC;
    }

}
public class CEO : Employee
{
    public CEO(string name = "Abhi", decimal basic = 100, short deptno = 10) : base(name, deptno,basic)
    {
    }
    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 150000 && value <= 350000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }
    }

   public override decimal CalNetSalary()
    {
        if (BASIC >= 150000 && BASIC <= 350000)
        {
            decimal netSal = BASIC + 15000;
            return netSal;
        }
        return BASIC;
    }
}

