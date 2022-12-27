using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__
{
    class MotorCycle
    {
        public int driverIntensity;

        // предоставление имени водителя
        public string driverName;
        //связывание конструкторов в цепочку

        //стандартный конструктор
        public MotorCycle() { }

        //специальный конструктор 
        public MotorCycle(int intensity)
            : this(intensity, " ") { }
        public MotorCycle(string name)
            : this(0, name) { }
        //главный конструктор выполняющий работу 
        public MotorCycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i= 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaw!");
            }
        }

        public void SetDriverName(string name)
        {
            driverName = name;
            this.driverName = name;
        }


        
    }    
}
