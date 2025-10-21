using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHW
{
    internal class Program
    {
        
        public class Employee
        {
            private string fullname;
            private int salary;
            private int yearsofexperience;
            public string FullName
            {
                get { return fullname; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Length < 1)
                        throw new ArgumentException("Полето е празно!!");
                    fullname = value;
                }
            }
            public int Salary
            {
                get { return salary; }
                set
                {
                    if (value < 800)
                        throw new ArgumentException("Въведената заплата е под 800лева");
                    salary = value;
                }
            }
            public int YearsOfExperience
            {
                get { return yearsofexperience; }
                set
                {
                    if (value < 0 || value > 50)
                        throw new ArgumentException("Въведените години за опит трябва да бъдат между 0 и 50");
                    yearsofexperience = value;
                }
            }
            public Employee(string fullname, int salary, int yearsofexperience)
            {
              this.FullName=fullname;
              this.Salary = salary;
                this. YearsOfExperience=yearsofexperience;
            }
            
        }

        

        
        static void Main(string[] args)
        {
            string fullname;int salary; int yearsofexperience;
            
            while(true)
            {
                Console.WriteLine("Въведи име");
                fullname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(fullname)) break;
                    Console.WriteLine("Опитай пак");
            }
            fullname =Console.ReadLine();
            Console.WriteLine("Въведи стойност на заплата");
            while(!int.TryParse(Console.ReadLine(),out salary))
            {
                Console.WriteLine("Опитай пак");
            }
            Console.WriteLine("Въведи години опит");
            while(!int.TryParse(Console.ReadLine(),out yearsofexperience))
            {
                Console.WriteLine("Опитай пак");

            }
            try 
            {
                Employee employee = new Employee(fullname,salary,yearsofexperience);
                Console.WriteLine(" Записан служител");
                Console.ReadLine();
            
            }
            catch (Exception ex) 
            {
              Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
