using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    class dog
    {
        public void bark()
        {
            Console.WriteLine("Bark Bark...!");
        }
    }
    class cat
    {
        public void meow()
        {
            Console.WriteLine("Meow meow");
        }
    }
    class robot
    {
        public void move()
        {
            Console.WriteLine("Moving");
        }
    }
    class superRobot
    {
        robot o1 = new robot();
        dog o2 = new dog();
        cat o3 = new cat();

        public void bark()
        {
            o2.bark();
        }
        public void meow()
        {
            o3.meow();
        }
        public void move()
        {
            o1.move();
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {

            superRobot sr = new superRobot();
            sr.bark();
            sr.meow();
            sr.move();
            Console.ReadKey();

        }
    }
}
