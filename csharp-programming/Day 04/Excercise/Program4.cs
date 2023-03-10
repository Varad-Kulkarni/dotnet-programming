using System.Security.Cryptography.X509Certificates;

namespace Excercise {
    class CircularBuffer {
        private int[] queue;
        private int front = 0;
        private int rear = -1;
        private int size = 0;

        public CircularBuffer(int size) {
            queue = new int[size];
        }

        public int this[int index] {
            get { return queue[index]; }
            set { queue[index] = value; }
        }

        public void Enqueue(int val) {
            if (size == queue.Length) {
                throw new Exception("Queue overflow...");
            }
            if(front == 0 && rear == -1) {
                rear = 0;
            }
            int index = front++ % queue.Length;
            this[index] = val;
            size++;
        }

        public void Dequeue() {
            if (size == 0) {
                throw new Exception("Queue Underflow...");
            }
            if(rear == queue.Length - 1) {
                queue[rear] = -1;
                rear = queue.Length - 1;
                size--;
                return;
            }
            queue[rear++ % queue.Length] = -1;
            size--;
        }
    }

    class Program {
        public static void Main(string[] args) {
            CircularBuffer cf = new CircularBuffer(7);
            cf.Enqueue(1);
            cf.Enqueue(2);
            cf.Enqueue(3);
            cf.Enqueue(4);
            cf.Enqueue(5);
            cf.Enqueue(6);
            cf.Enqueue(7);
            cf.Dequeue();
            cf.Dequeue();
            cf.Dequeue();
            cf.Dequeue();
            cf.Dequeue();
            cf.Dequeue();
            cf.Dequeue();
        }
    }
}