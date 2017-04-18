using System;

namespace InterfacesPart2
{
    class ShitEngine : IEngine // двигатель летающий на искусстве российской эстрады
    {
        public int Weight { get; }

        public int Power { get; }

        public ShitEngine()
        {
            Weight = 2000;
            Power = 1000;
        }

        public void Start()
        {
            Console.WriteLine("Алла, спойте нам пожалуйста про розы!");
        }

        public void Stop()
        {
            Console.WriteLine("Лучше нагрузите Витю АК");
        }
    }
}
