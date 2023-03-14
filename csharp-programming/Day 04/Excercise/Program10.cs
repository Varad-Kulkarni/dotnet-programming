namespace Excercise {
    class DateTimeExtension {
        private DateTime dt;

        public DateTimeExtension(DateTime dt) {
            this.dt = dt;
        }

        public string ToShortDate() {
            if(this.dt == null) {
                throw new Exception("date should not be null");
            }
            return $"{this.dt.Day}/{this.dt.Month}/{this.dt.Year}";
        }
    }

    class Program {
        public static void Main() {
            DateTimeExtension d1 = new DateTimeExtension(DateTime.Now);
            Console.WriteLine(d1.ToShortDate());
        }
    }
}