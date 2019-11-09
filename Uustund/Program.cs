using System;

namespace Uustund
{
    class Animal
    {
        public string name;
        public int age;
        public double levelOfHappiness;

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Level of happiness:{levelOfHappiness}");
        }

        public void ShowLevelOfHappiness()
        {
            Console.WriteLine($"Level of happiness:{levelOfHappiness}"); 
        }

        
    }
    //inheritance
    class Dog:Animal
    {
        public int spotCount = 0;
        public int numbersOfBarks = 0;

        public void Bark()
        {
            Console.WriteLine("Wuf");
            numbersOfBarks++;
            levelOfHappiness += 0.1;
            //add 5 spots every time the dog barks spotCount +=5;
            
            //add 1-5 spots every time dog barks 
            int randomNumberOfSpots;
            Random rnd =new Random();
            randomNumberOfSpots = rnd.Next(0,6);
            spotCount += randomNumberOfSpots;

        }

        public void ShowNumberOfDogSpots()
        {
            //display the numbers of spots
            Console.WriteLine($"{name} has now {spotCount} numbers of spots.");
        }
        
    }

    class Cat:Animal
    {
        public double levelOfCuteness;

        public void Meow()
        {
            Console.WriteLine("Meow");
            levelOfCuteness -= 0.1;
            levelOfHappiness += 0.1;
        }

        public void ShowLevelOfCuteness()
        {
            Console.WriteLine($"Cats level of cuteness {levelOfCuteness} ");
        }

        public void HearBarks(int numberOfBarks)
        {
            levelOfHappiness -= 0.1 * numberOfBarks;
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Kass
            /*Animal nurr= new Animal();
            nurr.name = "Nurr";
            nurr.age = 15;
            nurr.levelOfHappiness = 0.1;*/
            
            //Koer
            Dog scooby=new Dog();
            scooby.name = "ScoobyDoo";
            scooby.age = 1;
            scooby.levelOfHappiness = 0.1;
            scooby.spotCount = 5;
            
            //koera baasinfo printimine 
            scooby.PrintAnimalBaseInfo();
            
            //kass miisu
            Cat miisu=new Cat();
            miisu.name = "Miisu";
            miisu.age = 2;
            miisu.levelOfHappiness = 0.5;
            miisu.levelOfCuteness = 1;

            for (int i = 0; i < 5; i++)
            {
                miisu.Meow();
            }

            miisu.ShowLevelOfCuteness();
            
            //pane koer 20x haukuma 
            for (int i = 0; i < 20; i++)
            {
                scooby.Bark();
            }
            
            miisu.HearBarks(scooby.numbersOfBarks);
            if (miisu.levelOfHappiness < 0)
            {
                Console.WriteLine($"{miisu.name} died of stress.");
                miisu = null;
            }
            
            scooby.ShowNumberOfDogSpots();
            scooby.ShowLevelOfHappiness();
            
            
            Console.ReadLine();
        }
    }
    
    
}