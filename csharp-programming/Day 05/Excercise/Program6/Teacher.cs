namespace Excercise {
    class Teacher : Person {
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public override void Greet() {
            Console.WriteLine("Hello, I'm {0} {1}, a teacher of {2} for {3} years.", this.FirstName, this.LastName, this.Subject, this.YearsTeaching);
        }

        public override void Farewell() {
            Console.WriteLine("Have a good day, {0}.", this.FirstName);
        }
    }
}