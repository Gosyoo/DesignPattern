using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    /// <summary>
    /// 访问者接口
    /// </summary>
    public interface Visitor
    {
        //访问者 通过方法重载  针对不同元素的内容进行访问

        public void visit(Engineer staff);

        public void visit(Manager manager);
    }
}
