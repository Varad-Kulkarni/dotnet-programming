namespace Excercise {
    class Student : Person {
        public string School { get; set; }
        public int GradeLevel { get; set; }

        public override void Greet() {
            Console.WriteLine("Hi, I'm {0} {1}, a student at {2}.", this.FirstName, this.LastName, this.School);
        }

        public override void Farewell() {
            Console.WriteLine("Goodbye, {0}.", this.FirstName);
        }
    }
}