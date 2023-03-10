using System.Runtime.CompilerServices;

namespace Excercise {
    class TemperatureSensor {
        private double temperature;
        public delegate void TemperatureChanged(double temperature);
        public event TemperatureChanged Change;

        public void ReadTemperature() {
            Random random = new Random();
            double temperature = (random.NextDouble() % 100) * 100;
            this.temperature = temperature;
            Change(temperature);
        }
    }

    class Alarm {
        private bool isActivated;
        public void ActivateAlarm(double temperature) {
            if(temperature > 50) {
                this.isActivated = true;
            } 
            else {
                DeActivateAlarm();
            }
        }

        public void DeActivateAlarm() {
            this.isActivated = false;
        }

        public bool GetStatus() {
            return this.isActivated;
        }
    }

    class Program {
        public static void Main(string[] args) {
            TemperatureSensor ts = new TemperatureSensor();
            Alarm alarm = new Alarm();

            ts.Change += alarm.ActivateAlarm;
            Console.WriteLine(alarm.GetStatus());
            ts.ReadTemperature();
            Console.WriteLine(alarm.GetStatus());
            ts.ReadTemperature();
            Console.WriteLine(alarm.GetStatus());
            ts.ReadTemperature();
            Console.WriteLine(alarm.GetStatus());
            ts.ReadTemperature();
            Console.WriteLine(alarm.GetStatus());
        }
    }
}