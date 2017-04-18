namespace InterfacesPart2
{
    interface IEngine
    {
        void Start();       // метод для запуска
        void Stop();        // метод для остановки
        int Weight { get; } // масса двигателя 
        int Power { get; }  // мощность двигателя
    }
}
