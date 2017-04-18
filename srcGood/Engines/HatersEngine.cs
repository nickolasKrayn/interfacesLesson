using System;

namespace InterfacesPart2
{
    class HatersEngine : IEngine // двигатель летающий на тяге пердаков хуйтеров
    {
        public int Weight { get; }     // масса двигателя
        public int Power { get; }      // мощность двигателя
        public string GetCop { get; }  // получаем копирайты

        public HatersEngine()
        {
            Weight = 322;
            Power = 228;
            GetCop = "ExtremeCodeTV EngineCreator";
        }

        public void Start()
        {
            Console.WriteLine("Пуканы раскаляются, тяга на максимум");
        }

        public void Stop()
        {
            Console.WriteLine("Вброс годного контента. Пуканы остывают");
        }
    }
}
