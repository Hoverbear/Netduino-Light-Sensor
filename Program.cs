using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using Light_Sensor;

namespace Light_Sensor
{
    public class Program
    {
        // Sensor
        static AnalogInput Sensor = new AnalogInput(Pins.GPIO_PIN_A0);
        static int Range = 10;

        // Sleep time
        static int TransmissionGap = 500;

        // Display
        static OutputPort[] LEDArray = {
                new OutputPort(Pins.GPIO_PIN_D0, false), 
                new OutputPort(Pins.GPIO_PIN_D1, false), 
                new OutputPort(Pins.GPIO_PIN_D2, false), 
                new OutputPort(Pins.GPIO_PIN_D3, false), 
                new OutputPort(Pins.GPIO_PIN_D4, false), 
                new OutputPort(Pins.GPIO_PIN_D5, false), 
                new OutputPort(Pins.GPIO_PIN_D6, false),
                new OutputPort(Pins.GPIO_PIN_D7, false)
            };
        static SegmentLED LED = new SegmentLED(LEDArray);


        public static void Main()
        {
            // Initialize the value.
            int Value = 0;
            // Setup the range.
            Sensor.SetRange(0, Range);

            // Initialization test.
            for (int i = 0; i <= 10; i++)
            {
                LED.Display(i);
                Thread.Sleep(2000);
            }

            // Read, Print, Transmit, Sleep loop.
            while (true)
            {
                Value = Sensor.Read(); // So we only read once.
                Debug.Print("Value to Transmit: " + Value);
                LED.Display(Value);
                Thread.Sleep(TransmissionGap); // Sleep for a short time.
            }
        }
    }
}
