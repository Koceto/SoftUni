using System.Collections.Generic;
using System.Linq;

namespace FirstExercise
{
    public class Family
    {
        public List<Person> People = new List<Person>();

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = People.FirstOrDefault();

            foreach (var person in People)
            {
                if (person.age > oldest.age)
                {
                    oldest = person;
                }
            }

            return oldest;
        }
    }
}