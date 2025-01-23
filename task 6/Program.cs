using System;
using System.Xml.Linq;
//Create a struct Point with X and Y attributes. 
//o Add constructors: default and parameterized. 
//o Override the ToString() method to print the point as (X, Y).
public struct Point
{
    public int X;
    public int Y;
    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class PointExample
{
    public static void Main(string[] args)
    {
        // Create Point objects
        Point origin = new Point();
        Point p1 = new Point(3, 4);

        // Print Point objects
        Console.WriteLine("Origin: " + origin);
        Console.WriteLine("Point 1: " + p1);

        Console.ReadKey();
    }
}
//Create a class TypeA with attributes F (private), G(internal), and H(public). 
//o Write a program to access these attributes from different parts of the project. 
public class TypeA
{
    private int f;
    internal int G;
    public int H;

    public TypeA(int f, int g, int h)
    {
        this.f = f;
        G = g;
        H = h;
    }

    public void PrintF()
    {
        Console.WriteLine($"Value of F: {f}");
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            TypeA obj = new TypeA(10, 20, 30);
            Console.WriteLine($"Value of H: {obj.H}");
            obj.G = 50;
            Console.WriteLine($"Value of G: {obj.G}");
            obj.PrintF();
        }
    }
}
//Define a struct Employee with private attributes (EmpId, Name, Salary). 
//o Use methods (GetName, SetName) and properties to access these attributes. 
//o Write a test program to demonstrate encapsulation in action. 

public struct Employee
{
    private int empId;
    private string name;
    private double salary;

    public Employee(int empId, string name, double salary)
    {
        this.empId = empId;
        this.name = name;
        this.salary = salary;
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string newName)
    {
        name = newName;
    }
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}

public class EmployeeTest
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee(1, "John Doe", 50000);
        Console.WriteLine($"Employee Name: {emp.GetName()}");
        Console.WriteLine($"Employee Salary: {emp.Salary}");
        emp.SetName("Jane Doe");
        Console.WriteLine($"Updated Employee Name: {emp.GetName()}");
        emp.Salary = 60000;
        Console.WriteLine($"Updated Employee Salary: {emp.Salary}");
    }

    //o Modify the ToString() method of the Point struct to include custom formatting. 
    //o Write a program to test this by creating and printing multiple points. 
    public struct Point
    {
        public int X;
        public int Y;
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public class test
        {
            public static void Main(string[] args)
            {
                Point point1 = new Point(5);
                Point point2 = new Point(2, 3);
                Point point3 = new Point(-1, 4);

                Console.WriteLine(point1);
                Console.WriteLine(point2);
                Console.WriteLine(point3);

                Console.ReadKey();
            }
        }
    }
}
