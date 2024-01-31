using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum");
            int sum = numbers.Sum();
            Console.WriteLine(sum);


            //TODO: Print the Average of numbers
            Console.WriteLine("Average");
            double average = numbers.Average();
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending order");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));


            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Reverse Order");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("More than 6");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("First 4 numbers");
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Employees' whose name starts with \"C\" or \"S\".");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith( "S")).ToList().ForEach(x => Console.WriteLine(x.FullName));
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full name and age : {x.FullName}, {x.Age}."));
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            int sumYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList().Sum(x => x.YearsOfExperience);
            Console.WriteLine($"The sum of years of experience is {sumYearsOfExperience}.");
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            double averageYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList().Average(x => x.YearsOfExperience);
            Console.WriteLine($"The average of years of experience is {averageYearsOfExperience}.");
            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = CreateNewEmployee();
            Console.WriteLine("Updated employees list:");
            employees.Concat(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        private static List<Employee> CreateNewEmployee()
        {
            List<Employee> newEmployee = new List<Employee>();
            newEmployee.Add(new Employee("Amoriss", "Mallet", 32, 4));
            

            return newEmployee;
        }
        #endregion
    }
}
