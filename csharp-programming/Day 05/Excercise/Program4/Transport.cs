namespace Excercise {
    abstract class Transport {
        protected double MaxSpeed { get; set; }
        protected int Capacity { get; set; }

        public abstract void Move();
        public abstract void Stop();
    }
}