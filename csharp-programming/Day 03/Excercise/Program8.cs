namespace Excercise {
    enum Light {
        Red,
        Yellow,
        Green
    }

    class TrafficLight {
        private Light light;
        public TrafficLight() {
            this.light = Light.Yellow;
        }
        public Light ChangeColor() {
            if(this.light == Light.Red) {
                this.light = Light.Yellow;
            }
            else if(this.light == Light.Yellow) {
                this.light = Light.Green;
            }
            else {
                this.light = Light.Red;
            }

            return this.light;
        }
    }

    class Program {
        public static void Main(string[] args) {
            TrafficLight t = new TrafficLight();
            Console.WriteLine(t.ChangeColor());
            Console.WriteLine(t.ChangeColor());
            Console.WriteLine(t.ChangeColor());
            Console.WriteLine(t.ChangeColor());
            Console.WriteLine(t.ChangeColor());
            Console.WriteLine(t.ChangeColor());
        }
    }
}