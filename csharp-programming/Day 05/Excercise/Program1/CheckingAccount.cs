namespace Excercise {
    class CheckingAccount : Accounts {
        public double OverdraftLimit { get; set; }
        public CheckingAccount(double amount) {
            this.OverdraftLimit = -amount;
        }

        public override void Withdraw(double amount) {
            if (amount < 0) {
                throw new Exception("Invalid operation...");
            }
            if (base.Balance - amount < this.OverdraftLimit) {
                throw new Exception("Invalid operation...");
            }
            base.Balance -= amount;
        }
    }
}