namespace Excercise {
    class Accounts {
        public int AccountNo { get; set; }
        public double Balance { get; set; }
        public double IntrestRate { get; set; }

        public Accounts() {
            this.AccountNo = 123456;
            this.Balance = 0;
            this.IntrestRate = 0;
        }

        public void Deposite(double amount) {
            if (amount < 0) {
                throw new Exception("Invalid operation...");
            }
            this.Balance += amount;
        }

        public virtual void Withdraw(double amount) {
            if(this.Balance - amount < 0) {
                throw new Exception("Invalid operation...");
            }
            this.Balance -= amount;
        }

        public double CalculateIntrestRate(double period) {
            return this.Balance * (this.IntrestRate / 12.0) * period;
        }
    }
}