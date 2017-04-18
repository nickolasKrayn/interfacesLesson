using System;

namespace InterfacesPart2Bad
{
    /// <summary>
    /// Этот код написан без использования интерфейсов
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Так как общей абстракции нету, нам приходится к каждому движку писать по своей ракете
            CryRocket cRocket = new CryRocket();
            cRocket.Header = new RocketHeader();
            cRocket.Engine = new CryEngine();
            Console.WriteLine("На слезах хейтеров: " + SpecialNasaMethod(cRocket.Engine.Power, cRocket.Weight));

            HatersRocket hRocket = new HatersRocket();
            hRocket.Header = new RocketHeader();
            hRocket.Engine = new HatersEngine();
            Console.WriteLine("Хейтерская тяга: " + SpecialNasaMethod(hRocket.Engine.Power, hRocket.Weight));

            LozaRocket lRocket = new LozaRocket();
            lRocket.Header = new RocketHeader();
            lRocket.Engine = new YriyLozaEngine();
            Console.WriteLine("На пафосе Юрия Лозы: " + SpecialNasaMethod(lRocket.Engine.Power, lRocket.Weight));

            PoliticRocket pRocket = new PoliticRocket();
            pRocket.Header = new RocketHeader();
            pRocket.Engine = new PoliticsTalksEngine();
            Console.WriteLine("На пи*деже политиков: " + SpecialNasaMethod(pRocket.Engine.Power, pRocket.Weight));

            ShitRocket sRocket = new ShitRocket();
            sRocket.Header = new RocketHeader();
            sRocket.Engine = new ShitEngine();
            Console.WriteLine("На песнях российской эстрады: " + SpecialNasaMethod(sRocket.Engine.Power, sRocket.Weight));

            Console.ReadKey();
        }

        public static int SpecialNasaMethod(int power, int mass) // метод для вычисления максимальной скорости
        {
            return (mass / power * 10) + 82;
        }
    }
}
