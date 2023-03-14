namespace Excercise {
    class iPhone : Phone {
        private string ios_version;
        private bool fingerprint_scanner;

        public override void Call() {
            Console.WriteLine("Calling from an iPhone.");
        }
        public override void Text() {
            Console.WriteLine("Sending a text message from an iPhone.");
        }
    }
}