using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Engine
    {
        private int _weight;

        private int _power;

        public Engine(int weight, int power)
        {
            _weight = weight;
            _power = power;
        }

        public void Start()
        {
            Console.WriteLine("Двигатель запустился");
        }


        public void Stop()
        {
            Console.WriteLine("Двигатель остановился");
        }
    }
}
