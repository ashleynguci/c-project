using System;
using System.Collections.Generic;
using System.Threading;
using Tamagochi;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Tamagotchi> t = new List<Tamagotchi>();

            t.Add(new Dude("John") { Pace = 3 });
            t.Add(new Dude("Wacko") { Pace = 4 });


            foreach (var v in t)
            {
                Console.WriteLine(v);
            }
            uint rounds = (uint)new Random().Next(10, 20);
            while (rounds >= 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"round: {rounds}");
                foreach (var v in t)
                {
                    v.Act(rounds);
                    (v as Dude).Treat();
                }
                if (rounds-- == 1)
                    break;
            }
        }
    }
}
