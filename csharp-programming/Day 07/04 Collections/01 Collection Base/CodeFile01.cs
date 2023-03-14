using System.Collections;

namespace csharp_programming {
    public class MyCollection : CollectionBase {
        public void Add(Object item) {
            List.Add(item);
        }

        public void Remove(Object item) {
            List.Remove(item);
        }

        public Object this[int index] {
            get { return List[index]; }
            set { List[index] = value; }
        }
    }
}