using System;

namespace InterfacesPart2
{
    class YriyLozaEngine : IEngine // двигатель летающий на пафосе Юрия Лозы
    {
        public int Weight { get; }

        public int Power { get; }

        public YriyLozaEngine()
        {
            Weight = 500;
            Power = 2000; // мощный пи*дец
        }

        public void Start()
        {
            Console.WriteLine("Юрий, что вы думаете о группе Металлика?");
        }

        public void Stop()
        {
            Console.WriteLine("Юрий, сыграйте на бис");
        }
    }
}
