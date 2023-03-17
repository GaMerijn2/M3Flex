using System;

namespace ClassOpdracht1
{
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise //class
    {
        private readonly string accountName; 

        internal ClassStructureExercise(string accountName) //Constructor
        {
            this.accountName = accountName;  
        }

        internal void ShowGreetingInConsole() //Function
        {
            string greeting = "hello"; 
            Console.WriteLine(greeting + " " + accountName); 
        }

        internal void Show1To10() //Function
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i.ToString()); 
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //Variable
        {

            int dx = x2 - x1; 
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy); 

            double length = Math.Sqrt(lengthSquared); 
            return length; 

        }
        internal int MultiplyToPower2(int value) //Constructor
        {
            int result = value * value; 
            return result; 
        }


        static void Main(string[] args) //Constructor
        {
            Console.WriteLine("Hello, World!"); 

        }
    }
}