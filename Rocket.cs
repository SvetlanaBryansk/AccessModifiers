using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Rocket
    {
        private Engine _engine;

        private RocketHead _head;

        public Rocket(Engine engine, RocketHead head)
        {
            _engine = engine;
            _head = head;
        }

        public  void Launch()
        {
            _engine.Start();
        }

        protected void StopEngine()
        {
            _engine.Stop();
        }
    }
}
