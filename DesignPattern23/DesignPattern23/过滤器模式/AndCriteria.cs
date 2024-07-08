using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    public class AndCriteria : Criteria
    {
        public Criteria criteria1;
        public Criteria criteria2;

        public AndCriteria(Criteria criteria, Criteria other)
        {
            criteria1 = criteria;
            criteria2 = other;
        }

        public List<Person> meetCriteria(List<Person> person)
        {
            return criteria1.meetCriteria(criteria2.meetCriteria(person));
        }
    }
}
