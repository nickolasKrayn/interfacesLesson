using System;

namespace InterfacesPart2Bad
{
    class PoliticsTalksEngine  // Двигатель летающий на пиздеже политиков
    {
        public int Weight { get; }

        public int Power { get; }

        public PoliticsTalksEngine()
        {
            Weight = 100; // так мало весит, потому что пи*деть - не мешик ворочать
            Power = 5000;
        }

        public void Start()
        {
            Console.WriteLine("Чё там с дорогами?");
        }

        public void Stop()
        {
            Console.WriteLine("Приглашены ФСБшники из антикоррупционного отдела");
        }
    }
}
