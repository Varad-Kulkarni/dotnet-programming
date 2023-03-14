namespace Excercise {
    class Train : Transport {
        public int NumCars { get; set; }
        public int NumPassangers { get; set; }

        public override void Move() {
            Console.WriteLine("The train is chugging down the tracks.");
        }

        public override void Stop() {
            Console.WriteLine("The train has reached its destination.");
        }
    }
}