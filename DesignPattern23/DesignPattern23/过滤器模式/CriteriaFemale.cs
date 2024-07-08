﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    internal class CriteriaFemale : Criteria
    {
        public List<Person> criteria = new List<Person>();
        public List<Person> meetCriteria(List<Person> person)
        {
            criteria.Clear();
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].Gender == "Female")
                {
                    criteria.Add(person[i]);
                }
            }
            return criteria;
        }
    }
}
