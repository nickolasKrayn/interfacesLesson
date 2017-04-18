namespace InterfacesPart2Bad
{
    class CryRocket // ракета для движка на слезах фанатов
    {
        public RocketHeader Header { get; set; }  // головная часть
        public CryEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
