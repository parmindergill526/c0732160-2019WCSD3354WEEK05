using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
            Console.ReadLine();
        }
    }
    class TestQuestion2
    {
        public int myFavouiteVariable = 0;
        public void PlayingWithForLoops()
        {
            // write a for loop to add 10 numbers
            for (;MyMethod() ; )
            {
                if (myFavouiteVariable > 10)
                {
                    Console.WriteLine("I am so out of here");
                    break;
                }
                Console.WriteLine("i am in the for loop");
            }
        }
        public bool MyMethod()
        {
            myFavouiteVariable++;
            return true;
        }
    }
    class dog
    {
        public dog(String name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }

        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog previous_dog;
    }
    class birthdayParty
    {
        public dog fifo;
        public dog sandeep;
        public dog sadeala;
        public dog lander;
        public dog head;
        public dog tail;
    }
}
