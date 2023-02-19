using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket(new Engine(200000, 10000), new RocketHead(400000, 200));

            rocket.Launch();
        }
    }
}
