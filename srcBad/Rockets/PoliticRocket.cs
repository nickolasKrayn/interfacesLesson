namespace InterfacesPart2Bad
{
    class PoliticRocket // Ракета на пи*деже политиков
    {
        public RocketHeader Header { get; set; }  // головная часть
        public PoliticsTalksEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
