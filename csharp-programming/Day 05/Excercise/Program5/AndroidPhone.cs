namespace Excercise {
    class AndroidPhone : Phone {
        private string android_version;
        private int num_cameras;

        public override void Call() {
            Console.WriteLine("Calling from an Android phone.");
        }
        public override void Text() {
            Console.WriteLine("Sending a text message from an Android phone.");
        }
    }
}