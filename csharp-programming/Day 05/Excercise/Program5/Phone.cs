namespace Excercise {
    abstract class Phone {
        private string brand;
        private string model;
        private double screen_size;

        public abstract void Call();
        public abstract void Text();
    } 
}