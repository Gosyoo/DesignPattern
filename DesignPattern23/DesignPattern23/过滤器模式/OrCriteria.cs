using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    public class OrCriteria : Criteria
    {
        public Criteria criteria1;
        public Criteria criteria2;

        public OrCriteria(Criteria criteria, Criteria other)
        {
            criteria1 = criteria;
            criteria2 = other;
        }

        public List<Person> meetCriteria(List<Person> person)
        {
            List<Person> result = criteria1.meetCriteria(person);
            List<Person> result2 = criteria2.meetCriteria(person);

            for (int i = 0; i < result2.Count; i++)
            {
                if (!result.Contains(result2[i]))
                {
                    result.Add(result2[i]);
                }
            }
            return result;
        }
    }
}
