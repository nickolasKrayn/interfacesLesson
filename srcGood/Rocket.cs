namespace InterfacesPart2
{
    class Rocket
    {
        public RocketHeader Header { get; set; } // головная часть
        public IEngine Engine { get; set; }      // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }

    }
}
