using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    /// <summary>
    /// 标准 类
    /// </summary>
    public class Person
    {

        public string Name;
        public string Gender;
        public string MaritalStatus;

        public Person(string name,string gender,string marital) {
            Name = name;
            Gender = gender;
            MaritalStatus = marital;
        }
    }
}
