namespace Excercise {
    public static class DateTimeExtension {
        public static string ToShortDate(this DateTime dt) {
            if (dt == null) {
                throw new Exception("date should not be null");
            }
            return $"{dt.Day}/{dt.Month}/{dt.Year}";
        }
        }
    class Program {
        public static void Main() {
            DateTime d1 = DateTime.Parse("16 march 2020");
            Console.WriteLine(d1.ToShortDate());
        }
    }
}