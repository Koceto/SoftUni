namespace FirstExercise
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
            : this(1)
        {
        }

        public Person(int age)
            : this(age, "No name")
        {
        }

        public Person(int age, string name)
        {
            this.name = name;
            this.age = age;
        }
    }
}