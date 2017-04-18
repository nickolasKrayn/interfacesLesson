using System;

namespace InterfacesPart2
{
    class CryEngine : IEngine // Двигатель летающий на слезах фанатов сборной России по футболу
    {
        public int Weight { get; }
        public int Power { get; }

        public CryEngine()
        {
            Weight = 800;
            Power = 2000;
        }

        public void Start()
        {
            Console.WriteLine("То что этот двигатель не оправдывает ваши ожидания - ваши проблемы");
        }

        public void Stop()
        {
            Console.WriteLine("Прохождение в плей-оф");
        }

        public void BeginAdvertising()
        {
            Console.WriteLine("Кушайте Лейс - пи*дец как вкусно");
        }
    }
}
