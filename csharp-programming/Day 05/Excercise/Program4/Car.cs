namespace Excercise {
    class Car : Transport {
        public string Model { get; set; }
        public int NumWheels { get; set; }

        public override void Move() {
            Console.WriteLine("The car is cruising down the highway.");
        }

        public override void Stop() {
            Console.WriteLine("The car has come to a stop.");
        }
    }
}