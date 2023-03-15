namespace Excercise {
    abstract class LinkedListNode<T> {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public abstract string ToString();
        public abstract int GetCount();
    }
}