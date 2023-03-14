using System.Globalization;

namespace csharp_programming {
    [Comment(Text = "Person class")]
    public class Person {
        [Comment(Text = "Person name")]
        public string Name { get; set; }

        [Comment(Text = "Person age")]
        public int Age { get; set; }

        [Comment(Text = "Person marital status")]
        public bool Married { get; set; }

        [Comment(Text = "Person graduation status")]
        public bool IsGraduate { get; set; }

        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}", Name, Age, Married, IsGraduate);
        }
    }
}