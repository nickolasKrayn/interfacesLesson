using System;

namespace InterfacesPart2
{
    class RocketHeader
    {
        public int Cosmonauts { get; private set; } // количество космонавтов
        public int MassShell { get; private set; }  // масса корпуса

        public RocketHeader()
        {
            Cosmonauts = 3;
            MassShell = 5000;
        }

        public int GetWeight() // возвращает общую массу модуля с учётом веса космонавтов
        {  
            return (Cosmonauts * 80) + MassShell;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Сообщение: ");
            Console.WriteLine(message);
            Console.WriteLine("отправлено");
        }
    }
}
