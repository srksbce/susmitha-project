using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MySQLQueryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            while (response != "exit")
            {
                Console.Write(">>");
                response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "emp":
                        employeeMenu();
                        break;
                    case "-h":
                        Console.WriteLine("emp\tDisplays the Employee database menu");
                        Console.WriteLine("exit\tWill exit the program");
                        Console.WriteLine("clear\tWill clear the console window");
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Command; for help type -h");
                        break;

                }
            }
        }
        static void employeeMenu()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("Type 'list' to list all employees.");
            Console.WriteLine("Type 'add' to add an employee.");
            Console.WriteLine("------------------------------");
            string response = "";
            while (response != "exit")
            {
                Console.Write("EmployeeMenu>");
                Console.WriteLine("Type 'list' to list all employees.");
                Console.WriteLine("Type 'add' to add an employee.");
                Console.WriteLine("------------------------------");
                string response = "";
                while (response != "exit")
                {
                    Console.Write("EmployeeMenu>");
                    response = Console.ReadLine();
                    switch (response.ToLower())
                    {
                        case "add":
                            getInfo();
                            break;
                        case "exit":
                            Console.WriteLine("Returning to Main Menu...");
                            break;
                        case "list":
                            Console.WriteLine("Here I will display all the SQL data");
                            break;
                        default:
                            Console.WriteLine("Invalid Command\n");

                            break;
                    }
                }

            }
            static void getInfo()
            {
                Console.Write("Employee id: ");
                string fname = Console.ReadLine();
                Console.Write("Employee Name: ");
                string lname = Console.ReadLine();
                Console.Write("Employee salary: ");
                string job = Console.ReadLine();
                addEmployee(empid, empname, empsalary);
            }
            static void addEmployee(int empid, string empname, int empsalary)
            {
                var connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='Server[@Name='SUSMITHA\SQLEXPRESS']/Database[@Name='snad']/Table[@Name='Table_1' and @Schema='dbo']';Integrated Security=True");
                SqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO Table_1(empid, empname, empsalary) values('" + empid + "', '" + empname + "', '" + empsalary + "');";
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Added " + empid + " " + empname + " to employee database.");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
