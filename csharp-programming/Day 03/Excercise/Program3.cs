namespace Excercise {
    class BankAccount {
        private int accountno;
        private string name;
        private double balance;

        public int Accountno {
            get { return this.accountno; }
            set { this.accountno = value; }
        }
        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }
        public double Balance {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public BankAccount(int accountno, string name, double balance) {
            this.accountno = accountno;
            this.name = name;
            this.balance = balance;
        }

        public void Deposite(double cash) {
            if(cash < 0) {
                Console.WriteLine("Invalid cash entered...");
            }
            else {
                this.balance += cash;
            }
        }

        public void Withdraw(double cash) {
            if(cash < 0) {
                Console.WriteLine("Invalid cash entered...");
            }
            else if(this.balance < cash) {
                Console.WriteLine("Balance must be greater than withdraw money");
            }
            else {
                this.balance -= cash;
            }
        }

        public void PrintBankBalance() {
            Console.WriteLine("Your balance is Rs. " + this.balance);
        }
    }

    class Program {
        public static void Main(string[] args) {
            BankAccount bank = new BankAccount(333666999, "ABC", 1000.0);
            bank.PrintBankBalance();
            bank.Deposite(2000);
            bank.PrintBankBalance();
            bank.Withdraw(1000.0);
            bank.PrintBankBalance(); 
        }
    }
}