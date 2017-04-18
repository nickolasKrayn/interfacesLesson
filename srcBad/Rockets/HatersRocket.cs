namespace InterfacesPart2Bad
{
    class HatersRocket // Ракета на тяге пердаков хуйтеров
    {
        public RocketHeader Header { get; set; }  // головная часть
        public HatersEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }

    }
}
