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
            var b = new birthdayParty();
            b.printPartyList();
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
        public dog()
        {

        }

        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog previous_dog;
    }
    class birthdayParty
    {
        public dog fifi;
        public dog peanut;
        public dog clarence;
        public dog roy;
        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("Fifi", "Poodle");
            clarence = new dog("Clarence", "German Sheppard");
            roy = new dog("Roy", "Beagle");

            peanut.previous_dog = null;
            peanut.next_dog = fifi;
            fifi.previous_dog = peanut;
            fifi.next_dog = clarence;
            clarence.previous_dog = fifi;
            clarence.next_dog = roy;
            roy.previous_dog = clarence;
            roy.next_dog = null;
            head = peanut;
            tail = roy;

        }
        public string printPartyList()
        {
            string inviteList = "*------*";
            temporary = head;
            while (temporary.next_dog != null)
            {
                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.next_dog;
            }
            return inviteList;
        }
    }
}
