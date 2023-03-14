namespace csharp_programming {
    public class Example<T> {
        private T value;

        public Example(T value = default) {
            this.value = value;
        }

        public void Print() {
            Console.WriteLine("value is " + this.value);
        }
    }

    class Program {
        public static void Main(string[] args) {
            Example<int> eg = new Example<int>();
            eg.Print();

            Example<string> eg1 = new Example<string>();
            eg1.Print();
        }
    }
}

// default value of expression can be used with generic types to provide default value to parameter