using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    /// <summary>
    /// 员工数据报表
    /// </summary>
    public class BusinessReport
    {

        public List<Staff> staffs = new List<Staff>();

        public BusinessReport()
        {
            staffs.Add(new Engineer(80, "工程师--1"));
            staffs.Add(new Engineer(90, "工程师--2"));
            staffs.Add(new Manager(70, "项目经理--1"));
            staffs.Add(new Engineer(80, "工程师--3"));
            staffs.Add(new Manager(90, "项目经理--2"));
            staffs.Add(new Engineer(70, "工程师--4"));
        }

        public void showReport(Visitor visitor)
        {
            for (int i = 0; i < staffs.Count; i++)
            {
                staffs[i].accept(visitor);
            }
        }
    }
}
