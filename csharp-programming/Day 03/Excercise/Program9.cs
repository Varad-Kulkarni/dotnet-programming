namespace Excercise {
    enum MeasurementUnit {
        Inch,
        Feet,
        Yard,
        Mile
    }

    class MeasurementConverter {
        public static double Convert(double val, MeasurementUnit ip, MeasurementUnit op) {
            double ans = 0.0;

            switch (ip) {
                case MeasurementUnit.Inch:
                    switch (op) {
                        case MeasurementUnit.Inch:
                            ans = val;
                            break;

                        case MeasurementUnit.Feet:
                            ans = val * 0.0833;
                            break;

                        case MeasurementUnit.Yard:
                            ans = val * 0.0277;
                            break;

                        case MeasurementUnit.Mile:
                            ans = val * 1.3715e-5;
                            break;
                    }
                    break;

                case MeasurementUnit.Feet:
                    switch (op) {
                        case MeasurementUnit.Inch:
                            ans = val * 12.0;
                            break;

                        case MeasurementUnit.Feet:
                            ans = val;
                            break;

                        case MeasurementUnit.Yard:
                            ans = val * 0.334;
                            break;

                        case MeasurementUnit.Mile:
                            ans = val * 0.000164;
                            break;
                    }
                    break;

                case MeasurementUnit.Yard:
                    switch (op) {
                        case MeasurementUnit.Inch:
                            ans = val * 36.0002;
                            break;

                        case MeasurementUnit.Feet:
                            ans = val * 3.00002;
                            break;

                        case MeasurementUnit.Yard:
                            ans = val;
                            break;

                        case MeasurementUnit.Mile:
                            ans = val * 0.00049;
                            break;
                    }
                    break;

                case MeasurementUnit.Mile:
                    switch (op) {
                        case MeasurementUnit.Inch:
                            ans = val * 72913.902;
                            break;

                        case MeasurementUnit.Feet:
                            ans = val * 6076.158;
                            break;

                        case MeasurementUnit.Yard:
                            ans = val * 2025.386;
                            break;

                        case MeasurementUnit.Mile:
                            ans = val;
                            break;
                    }
                    break;

            }
            return ans;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(MeasurementConverter.Convert(33, MeasurementUnit.Yard, MeasurementUnit.Inch));
        }
    }
}