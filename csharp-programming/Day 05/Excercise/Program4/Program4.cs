namespace Excercise {
    class Program {
        public static void Main() {
            Transport car = new Car();
            Transport train = new Train();

            car.Move();
            train.Move();
            train.Stop();
            car.Stop();
        }
    }
}