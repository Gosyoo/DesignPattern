using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    public class CTOVisitor : Visitor
    {
        //访问者 通过方法重载  针对不同元素的内容进行访问

        public void visit(Engineer staff)
        {
            //CTO 关注 工程师 kpi

            Console.WriteLine("name:" + staff.name + "  kpi:" + staff.kpi);
        }

        public void visit(Manager manager)
        {
            //CTO 关注 经理 kpi 和 新产品数量
            Console.WriteLine("name:" + manager.name + "    kpi:" + manager.kpi+ "  new product number:" + manager.GetNewProductCount());
        }
    }
}
