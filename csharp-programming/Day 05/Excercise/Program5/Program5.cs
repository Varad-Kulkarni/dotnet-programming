namespace Excercise {
    class Program {
        public static void Main() {
            Phone android = new AndroidPhone();
            android.Call();
            android.Text();

            Phone iphone = new iPhone();
            iphone.Call();
            iphone.Text();
        }
    }
}