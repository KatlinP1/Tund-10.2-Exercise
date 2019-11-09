using System;



namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson=new Person();
            newPerson.FirstName = "Mari";
            newPerson.LastName = "Pilv";
            
            newPerson.Introduce();

            Console.ReadLine();
        }
    }
}