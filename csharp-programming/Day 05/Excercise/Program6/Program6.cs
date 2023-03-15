namespace Excercise {
    class Program {
        public static void Main(string[] args) {
            Person student = new Student() {
                FirstName = "student_name",
                LastName = "student_surname",
                Age = 21,
                School = "student_school"
            };
            student.Greet();
            student.Farewell();

            Person teacher = new Teacher() {
                FirstName = "teacher_name",
                LastName = "teacher_surname",
                Age = 51,
                Subject = "Mathematics",
                YearsTeaching = 33
            };
            teacher.Greet();
            teacher.Farewell();
        }
    }
}