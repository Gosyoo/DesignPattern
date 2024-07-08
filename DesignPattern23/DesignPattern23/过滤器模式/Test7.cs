using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.过滤器模式
{
    public class Test7
    {
        public static void Test()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("==========男===========");
            Print(male.meetCriteria(persons));
            Console.WriteLine("==========女===========");
            Print(female.meetCriteria(persons));
            Console.WriteLine("==========单身===========");
            Print(single.meetCriteria(persons));
            Console.WriteLine("==========单身 男===========");
            Print(singleMale.meetCriteria(persons));
            Console.WriteLine("==========单身 或者 女===========");
            Print(singleOrFemale.meetCriteria(persons));
        }

        public static void Print(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                string Name = persons[i].Name;
                string Gender = persons[i].Gender;
                string MaritalStatus = persons[i].MaritalStatus;

                Console.WriteLine("Person Name:" + Name + "\tGender:" + Gender + "\tMarital：" + MaritalStatus);
            }
        }
    }
}
