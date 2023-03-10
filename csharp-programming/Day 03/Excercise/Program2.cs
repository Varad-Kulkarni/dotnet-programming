namespace Example {
    class Product {
        private string name;
        private double price;
        private int quantity;

        public string Name {
            get { return this.name; }
            set {
                if (value == "") {
                    throw new ArgumentNullException("Invalid name");
                }
                this.name = value;
            }
        }
        public double Price {
            get { return this.price; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Invalid price");
                }
                this.price = value;
            }
        }
        public int Quantity {
            get { return this.quantity; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Invalid quantity");
                }
                this.quantity = value;
            }
        }

        public double GetTotalValue() {
            return this.price * (double)this.quantity;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Product product = new Product();
            product.Name = "ABC";
            product.Price = 4.5;
            product.Quantity = 2;
            Console.WriteLine(product.GetTotalValue());
        }
    }
}