using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class HeavyRocket : Rocket
    {
        public HeavyRocket(Engine engine, RocketHead head) : base(engine, head)
        {
            //base.StopEngine();
        }
    }
}
