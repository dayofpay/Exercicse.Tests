using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Start
    {
        static void Main(string[] args)
        {
            RestartSoftware:
            try
            {
                Console.Write("Lines / First Name / Job Position / Employee Salary / Employee Age  >  ");
                var lines = Int32.Parse(Console.ReadLine());
                AgeTeam team = new AgeTeam("Git/Dayofpay");
                var employee_list = new List<Employees>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var employee = new Employees(cmdArgs[0], cmdArgs[1], Convert.ToInt32(cmdArgs[2]), Convert.ToInt32(cmdArgs[3]));
                    employee_list.Add(employee);
                    employee_list.ForEach(a => Console.WriteLine(a.ToString()));
                    team.AddPlayer(employee);
                    Console.WriteLine(team);
                }
            }catch(Exception error)
            {
                Console.WriteLine($"Detected Error {error}");
                System.Threading.Thread.Sleep(1450);
                Console.Clear();
                goto RestartSoftware;
            }
        }
    }
}
