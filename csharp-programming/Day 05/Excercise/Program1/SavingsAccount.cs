namespace Excercise {
    class SavingsAccount : Accounts {
        public double MinimumBalance { get; set; }

        public SavingsAccount() {
            this.MinimumBalance = base.Balance;
        }

        public override void Withdraw(double amount) {
            if (amount < 0) {
                throw new Exception("Invalid operation...");
            }
            if (this.Balance - amount < 0) {
                throw new Exception("Invalid operation...");
            }
            this.MinimumBalance = base.Balance;
            this.MinimumBalance -= amount;
            base.Balance -= amount;
        }
    }
}