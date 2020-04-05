using System;
using System.Collections.Generic;
using System.IO;

namespace PayrollApp
{
    public class FileReaderWriter
    {

        public List<Employee> EmployeeListReader(string employeePath)
        {
            string[] lines = File.ReadAllLines(employeePath);
            List<Employee> employeeList = new List<Employee>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Employee employee = new Employee();

                    var staffArray = line.Split('|');
                    employee.Name = staffArray[0];
                    employee.HoursWorked = Convert.ToDouble(staffArray[1]);

                    employeeList.Add(employee);
                }
            }

            return employeeList;
        }

        public List<Manager> ManagerListReader(string managerPath)
        {
            string[] lines = File.ReadAllLines(managerPath);
            List<Manager> managerList = new List<Manager>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Manager manager = new Manager();

                    var staffArray = line.Split('|');
                    manager.Name = staffArray[0];
                    manager.HoursWorked = Convert.ToDouble(staffArray[1]);

                    managerList.Add(manager);
                }
            }

            return managerList;
        }

        public List<ContractEmployee> ContractorListReader(string contractorPath)
        {
            string[] lines = File.ReadAllLines(contractorPath);
            List<ContractEmployee> contractEmployees = new List<ContractEmployee>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    ContractEmployee contractEmployee = new ContractEmployee();

                    var staffArray = line.Split('|');
                    contractEmployee.Name = staffArray[0];
                    contractEmployee.HoursWorked = Convert.ToDouble(staffArray[1]);

                    contractEmployees.Add(contractEmployee);
                }
            }

            return contractEmployees;
        }



        public void AddEmployeeHoursAsManager(string employeePath)
        {
            while (true)
            {
                //TODO: Write names and hours to a text file

                Console.WriteLine("What is the persons first name?");
                string firstName = Console.ReadLine().ToLower();

                Console.WriteLine("How many hours did they work?");
                string hours = Console.ReadLine().ToLower();


                using (StreamWriter writer = File.AppendText(employeePath))
                {
                    writer.WriteLine($"{firstName}|{hours}");
                    writer.Close();
                }

                Console.WriteLine($"{Environment.NewLine} Person has been added... {Environment.NewLine}");

                Console.WriteLine("Add another person? y or n");
                string addAnother = Console.ReadLine().ToLower();

                if (addAnother == "n")
                {
                    Console.WriteLine("Adding is complete...");
                    break;
                }
            }
        }

        public void AddManagerHoursAsManager(string managerPath)
        {
            while (true)
            {
                //TODO: Write names and hours to a text file

                Console.WriteLine("What is the persons first name?");
                string firstName = Console.ReadLine().ToLower();

                Console.WriteLine("How many hours did you work?");
                string hours = Console.ReadLine().ToLower();


                using (StreamWriter writer = File.AppendText(managerPath))
                {
                    writer.WriteLine($"{firstName}|{hours}");
                    writer.Close();
                }

                Console.WriteLine($"{Environment.NewLine} Person has been added... {Environment.NewLine}");

                Console.WriteLine("Add another person? y or n");
                string addAnother = Console.ReadLine().ToLower();

                if (addAnother == "n")
                {
                    Console.WriteLine("Adding is complete...");
                    break;
                }
            }
        }

        public void AddContractorHoursAsManager(string contractorPath)
        {
            while (true)
            {
                //TODO: Write names and hours to a text file

                Console.WriteLine("What is the persons first name?");
                string firstName = Console.ReadLine().ToLower();

                Console.WriteLine("How many hours did you work?");
                string hours = Console.ReadLine().ToLower();


                using (StreamWriter writer = File.AppendText(contractorPath))
                {
                    writer.WriteLine($"{firstName}|{hours}");
                    writer.Close();
                }

                Console.WriteLine($"{Environment.NewLine} Person has been added... {Environment.NewLine}");

                Console.WriteLine("Add another person? y or n");
                string addAnother = Console.ReadLine().ToLower();

                if (addAnother == "n")
                {
                    Console.WriteLine("Adding is complete...");
                    break;
                }
            }
        }


        //TODO: Add name and hours as an employee, manager, and contractor for one time

        public void AddHoursAsEmployee(string employeePath)
        {
            //TODO: Write names and hours to a text file

            Console.WriteLine("What is the persons first name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("How many hours did they work?");
            string hours = Console.ReadLine().ToLower();


            using (StreamWriter writer = File.AppendText(employeePath))
            {
                writer.WriteLine($"{firstName}|{hours}");
                writer.Close();
            }

            Console.WriteLine($"{Environment.NewLine} Person has been added... {Environment.NewLine}");
        }

        public void AddHoursAsContractor(string contractorPath)
        {
            //TODO: Write names and hours to a text file

            Console.WriteLine("What is the persons first name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("How many hours did you work?");
            string hours = Console.ReadLine().ToLower();


            using (StreamWriter writer = File.AppendText(contractorPath))
            {
                writer.WriteLine($"{firstName}|{hours}");
                writer.Close();
            }

            Console.WriteLine($"{Environment.NewLine} Person has been added... {Environment.NewLine}");

        }
    }
}
