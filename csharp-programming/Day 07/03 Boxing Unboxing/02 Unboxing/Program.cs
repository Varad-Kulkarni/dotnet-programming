namespace csharp_programming {
    internal class Program {
        static void Main() {
            Object a = 1;
            int i = (int)a;
            i += 5;
        }
    }
}

/*
 * Unboxing is explicit.
 * An unboxing operation involves determining whether the boxed value
 * is of the specified value type and, if so, copying the value from
 * the instance into the value-type variable. 
 * As a result, boxing and unboxing are thought to be computationally
 * expensive processes. 
 */
