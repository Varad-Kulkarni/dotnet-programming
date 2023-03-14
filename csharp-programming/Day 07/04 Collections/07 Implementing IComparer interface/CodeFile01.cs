namespace csharp_programming {
    public class Person1 {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonComparer : IComparer<Person1> {
        public int Compare(Person1 x, Person1 y) {
            return x.Name.CompareTo(y.Name);
        }
    }

    class Program {
        public static void Main(string[] args) {
                List<Person1> ls = new List<Person1>() {
                new Person1 {Name="Varad", Age=33 },
                new Person1 {Name="Warad", Age=66 },
                new Person1 {Name="VWarad", Age=99 }
            };
            ls.Sort(new PersonComparer());
        }
    }
}