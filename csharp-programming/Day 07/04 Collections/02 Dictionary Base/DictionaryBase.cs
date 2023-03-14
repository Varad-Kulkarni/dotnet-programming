using System.Collections;

namespace csharp_programming {
    internal class MyDictionary : DictionaryBase {
        public void Add(object key, object value) {
            Dictionary.Add(key, value);
        }

        public void Remove(object key) {
            Dictionary.Remove(key);
        }
    }
}
