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
        public MotorCycle()
        {
            Console.WriteLine("In defaut ctor"); //внутри стандартного конструктора
        }

        //специальный конструктор 
        public MotorCycle(int intensity)
            : this(intensity, " ") 
        {
            Console.WriteLine("In ctor taking an int"); //внутри конструктора принимающего int
        }
        public MotorCycle(string name)
            : this(0, name)
        {
            Console.WriteLine("In ctor taking a string"); //внутри конструктора принимающего string
        }
        //главный конструктор выполняющий работу 
        public MotorCycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor"); //внутри главного конструктора 
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
