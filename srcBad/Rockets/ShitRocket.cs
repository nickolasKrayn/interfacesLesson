namespace InterfacesPart2Bad
{
    class ShitRocket // ракета на тяге эстрады
    {
        public RocketHeader Header { get; set; }  // головная часть
        public ShitEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
