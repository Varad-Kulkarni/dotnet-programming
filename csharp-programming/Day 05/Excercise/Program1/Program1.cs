namespace Excercise {
    class Program {
        public static void Main() {
            SavingsAccount savings = new SavingsAccount();
            savings.IntrestRate = 3;
            savings.Deposite(100);
            Console.WriteLine(savings.CalculateIntrestRate(2));
            savings.Withdraw(50);
            // savings.Withdraw(51);

            CheckingAccount checking = new CheckingAccount(100);
            checking.IntrestRate = 3;
            checking.Deposite(100);
            Console.WriteLine(checking.CalculateIntrestRate(2));
            checking.Withdraw(150);
            // checking.Withdraw(51);
        }
    }
}