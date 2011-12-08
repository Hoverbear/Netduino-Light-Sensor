using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using Light_Sensor;

namespace Light_Sensor
{
    class SegmentLED
    {
        private OutputPort[] LEDArray;
        private bool[] state = new bool[8];

        public SegmentLED(OutputPort[] LEDArray)
        {
            this.LEDArray = LEDArray;
        }

        internal void Display(int Value)
        {
            foreach (OutputPort port in LEDArray)
            {
                port.Write(false);
            }
            switch (Value)
            {
                case 1:
                    LEDArray[1].Write(true); // 2
                    LEDArray[3].Write(true); // 7
                    break;
                case 2:
                    LEDArray[0].Write(true); // 1
                    LEDArray[1].Write(true); // 2
                    LEDArray[5].Write(true); // 9
                    LEDArray[6].Write(true); // 13
                    LEDArray[7].Write(true); // 14
                    break;
                case 3:
                    LEDArray[0].Write(true); // 1
                    LEDArray[1].Write(true); // 2
                    LEDArray[5].Write(true); // 9
                    LEDArray[3].Write(true); // 7
                    LEDArray[7].Write(true); // 14
                    break;
                case 4:
                    LEDArray[4].Write(true); // 8
                    LEDArray[5].Write(true); // 9
                    LEDArray[1].Write(true); // 2
                    LEDArray[3].Write(true); // 7
                    break;
                case 5:
                    LEDArray[0].Write(true); // 1
                    LEDArray[4].Write(true); // 8
                    LEDArray[5].Write(true); // 9
                    LEDArray[3].Write(true); // 7
                    LEDArray[7].Write(true); // 14
                    break;
                case 6:
                    LEDArray[0].Write(true); // 1
                    LEDArray[4].Write(true); // 8
                    LEDArray[5].Write(true); // 9
                    LEDArray[6].Write(true); // 13
                    LEDArray[3].Write(true); // 7
                    LEDArray[7].Write(true); // 14
                    break;
                case 7:
                    LEDArray[0].Write(true); // 1
                    LEDArray[1].Write(true); // 2
                    LEDArray[3].Write(true); // 7
                    break;
                case 8:
                    LEDArray[0].Write(true); // 1
                    LEDArray[4].Write(true); // 8
                    LEDArray[1].Write(true); // 2
                    LEDArray[5].Write(true); // 9
                    LEDArray[6].Write(true); // 13
                    LEDArray[3].Write(true); // 7
                    LEDArray[7].Write(true); // 14
                    break;
                case 9:
                    LEDArray[0].Write(true); // 1
                    LEDArray[4].Write(true); // 8
                    LEDArray[1].Write(true); // 2
                    LEDArray[5].Write(true); // 9
                    LEDArray[3].Write(true); // 7
                    LEDArray[7].Write(true); // 14
                    break;
                default:
                    LEDArray[2].Write(true); // 6
                    break;
            }
        }
    }
}
