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
        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++) 
            {
                Console.WriteLine("Yeeeeee Haaaaww!"); 
            }           
        }
        //возвращаем стандартный конструктор, котрый будет ставить стандартные значения 
        public MotorCycle() { }
    
        //специальный конструктор
        public MotorCycle(int intensity)
        {
            driverIntensity = intensity;
        } 
    }    
}
