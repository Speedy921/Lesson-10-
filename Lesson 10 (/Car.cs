using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__
{
    internal class Car
    {
        //Состояние обьекта Car 
        public string petName;
        public int currSpeed;

        //специальный стандартный конструктор 
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //здесь currSpeed получает стандартное значнеи для типа int (0)
        public Car(string pn)
        {
            petName = pn;
        }

        //позволяет вызывающему коду установить полное состояние обьекта Car
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;

        }

        //конструкторы с параметрами out 
        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        //Функциональность Сar
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void SpeedUp(int delta)
            => currSpeed += delta;
        
    }
}
