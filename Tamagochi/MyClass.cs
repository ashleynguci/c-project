using System;
namespace Tamagochi
{
    public abstract class Tamagotchi
    {
        protected uint happinessIndex;
        public readonly string name;
        private uint pace;
        protected Tamagotchi(string name)
        {
            this.name = name;
        }
        public uint Pace{
            get{
                return pace;
            }
            set{
                pace = value;
            }
        }
        virtual public bool Act(uint count){
            bool result = false;
            if(count % pace ==0){
                Eat();
                Sleep();
                Play();
                result = true;
            }
            return result;
        }
        virtual public void Sleep(){
            System.Console.WriteLine($"{GetType().Name}, {name};, sleeps");
        }
        virtual public void Eat(){
            System.Console.WriteLine($"{GetType().Name}, {name};, eats");
        }
        public void Play(){
            System.Console.WriteLine($"{GetType().Name}, {name};, plays");
        }

    }

    public class Dude : Tamagotchi
    {

        ///inheritant from Tamagotchi name
        public Dude(string name) : base(name)
        {
            happinessIndex = 7;
        }
        public override string ToString()
        {
            string a = $"{name}: reaction pace is {Pace} and current happiness index is {happinessIndex}";
            return a;
        }
        public void Treat()
        {
            happinessIndex += 10;
            System.Console.WriteLine($"{GetType().Name}, {name};, treats");
           }
    }

 }

