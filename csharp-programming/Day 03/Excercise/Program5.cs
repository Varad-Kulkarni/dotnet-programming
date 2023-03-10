namespace Excercise {
    class Address {
        private string street;
        private string city;
        private string state;
        private int zipCode;

        public Address(string street, string city, string state, int zipCode) {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }

        public void PrintAddress() {
            Console.WriteLine("Printing the address...");
            Console.WriteLine("Street = " + street);
            Console.WriteLine("City = " + city);
            Console.WriteLine("State = " + state);
            Console.WriteLine("Zip Code = " + zipCode);
        }
    }

    class Program {
        public static void Main(string[] args) {
            Address address = new Address("Raigadnagar", "Sambhajinagar", "Maharashtra", 431003);
            address.PrintAddress();
        }
    }
}