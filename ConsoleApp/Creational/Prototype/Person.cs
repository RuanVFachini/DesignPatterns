namespace ConsoleApp.Creational.Prototype
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }

        public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
        {
            Age = age;
            BirthDate = birthDate;
            Name = name;
            IdInfo = idInfo;
        }

        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = new string(Name);
            return clone;
        }
    }
}
