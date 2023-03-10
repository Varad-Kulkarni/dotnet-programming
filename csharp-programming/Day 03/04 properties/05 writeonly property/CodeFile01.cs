namespace csharp_programming {
    class Credentials {
        public string UserID { private get;  set; }
        public string Password { private get; set; }

        public void Validate() {}
    }

    class Program {
        static void Main() {
            Credentials cr = new Credentials();
            cr.UserID = "Scott";
            cr.Password = "tiger";
            string userId = cr.UserID; // property is writeonly
            string password = cr.Password; // property is writeonly
        }
    }
}

// Making get private makes property writeonly.
// Making set private makes property readonly.
// Making get and set private makes property to access read and write.