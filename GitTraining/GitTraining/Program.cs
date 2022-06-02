using System;

namespace GitTraining
{
    static class Program
    {
        static void Main(string[] args)
        {
            var greeting = new Greeting();
            greeting.SayHello();            
            Console.ReadLine();
            Console.WriteLine("Press any key to exit.");            
        }
    }

    public class Greeting
    {
        public void SayHello() 
        {
            Console.WriteLine("I am Minnh Hoang");
            //Write console your name here.
            Console.WriteLine("Hi, everyone ");
        }
    }
}
