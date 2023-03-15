namespace csharp_programming {
    class Program {
        public static void Main() {
            WriteErrorLogBinaryFile();
            ReadErrorLogBinaryFile();
        }

        static void WriteErrorLogBinaryFile() {
            using (BinaryWriter bw = new BinaryWriter(File.Open("errorlog.bin", FileMode.Create))) {
                bw.Write(0x80000003);
                bw.Write("One or more arguments are invalid");
            }
        }

        static void ReadErrorLogBinaryFile() {
            using (BinaryReader br = new BinaryReader(File.Open("errorlog.bin", FileMode.Open))) {
                Console.WriteLine("error code : " + string.Format("0x{0:x}", br.ReadInt32()));
                Console.WriteLine("Message : " + br.ReadString());
            }
        }
    }
}