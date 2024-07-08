using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.组合模式
{
    public class Employee
    {
        public string name;
        public string delp;
        public int salary;
        public List<Employee> employees = new List<Employee>();

        public Employee(string name, string delp, int salary)
        {
            this.name = name;
            this.delp = delp;
            this.salary = salary;
        }

        public void Add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            this.employees.Remove(employee);
        }

        public override string ToString()
        {
            return $"Employee:\tName:{this.name}\tDelp:{this.delp}\t:Salary:{this.salary}";
        }
    }
}
