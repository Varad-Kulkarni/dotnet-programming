using System.Diagnostics;

namespace csharp_programming {
    public class Stack<T> {
        private T[] items;
        private int top;

        public Stack(int size) {
            items = new T[size];
            top = -1;
        }

        public void Push(T item) {
            if (top == items.Length - 1) {
                throw new StackOverflowException();
            }
            items[++top] = item;
        }

        public T Pop() {
            if (top == -1) {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        public T Top {
            get {
                if (top == -1) {
                    throw new InvalidOperationException("Stack is empty");
                }
                return items[top];
            }
        }

        public bool IsEmpty => top == -1;
    }

    class Program {
        public static void Main(string[] args) {
            Stack<char> stack = new Stack<char>(10);
            string s = "Hello";

            foreach (char c in s) {
                stack.Push(c);
            }

            s = "";
            while (!stack.IsEmpty) {
                s += stack.Top;
                stack.Pop();
            }

            Debug.Assert(s == "olleH");

            Stack<int> stack1 = new Stack<int>(10);

            int[] s1 = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int c in s1) {
                stack1.Push(c);
            }

            int s2 = 0;
            while (!stack1.IsEmpty) {
                s2 += stack1.Top;
                stack1.Pop();
            }

            Debug.Assert(s2 == 15);
        }
    }
}