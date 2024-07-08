using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    /// <summary>
    /// 过滤器接口
    /// </summary>
    public interface Criteria
    {
        public List<Person> meetCriteria(List<Person> person);
    }
}
