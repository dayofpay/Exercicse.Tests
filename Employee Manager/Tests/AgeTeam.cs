using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class AgeTeam
    {
        private string employee;
        private int age;
        private List<Employees> teamOne;
        private List<Employees> teamTwo;
        public AgeTeam(string employee)
        {
            this.employee = employee;
            this.age = age;
            this.teamOne = new List<Employees>();
            this.teamTwo = new List<Employees>();
        }
        public IReadOnlyCollection<Employees> FirstTeam
        {
            get
            {
                return this.teamOne.AsReadOnly();
            }
        }
        public IReadOnlyCollection<Employees> SecondTeam
        {
            get
            {
                return this.teamTwo.AsReadOnly();
            }
        }
        public void AddPlayer(Employees employee)
        {
            if (employee.employees_age < 40)
            {
                teamOne.Add(employee);
            }
            else
            {
                teamTwo.Add(employee);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First team has {teamOne.Count} players.");
            sb.AppendLine($"Second team has {teamTwo.Count} players.");
            return sb.ToString().TrimEnd();
        }
    }
}
