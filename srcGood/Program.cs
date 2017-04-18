using System;

namespace InterfacesPart2
{
    /// <summary>
    /// Этот код написан с использованием интерфейсов
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket();
            rocket.Header = new RocketHeader();

            rocket.Engine = new HatersEngine();
            Console.WriteLine("Хейтерская тяга: " + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            rocket.Engine = new CryEngine();
            Console.WriteLine("На слезах хейтеров: " + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            rocket.Engine = new PoliticsTalksEngine();
            Console.WriteLine("На пи*деже политиков: " + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            rocket.Engine = new ShitEngine();
            Console.WriteLine("На песнях российской эстрады: " + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            rocket.Engine = new YriyLozaEngine();
            Console.WriteLine("На пафосе Юрия Лозы: " + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            Console.ReadKey();

        }


        public static int SpecialNasaMethod(int power, int mass) // метод для вычесления максимальной скорости
        {
            return (mass / power * 10) + 82;
        }
    }
}
