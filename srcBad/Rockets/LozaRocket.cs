namespace InterfacesPart2Bad
{
    class LozaRocket // ракета на пафосе Лозы
    {
        public RocketHeader Header { get; set; }  // головная часть
        public YriyLozaEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
