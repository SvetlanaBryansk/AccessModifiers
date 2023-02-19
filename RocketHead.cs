using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class RocketHead
    {
        private readonly int _weight;

        private readonly int _capacity;

        public RocketHead(int weight, int capacity)
        {
            _weight = weight;
            _capacity = capacity;
        }
    }
}
