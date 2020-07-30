using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            S obj = new K();
            obj.play();

           //K kb = obj.play();

            Console.ReadLine();
           
        }

        class S
        {
            
           public virtual S play()
            {
                return new S();
            }
        }
        class K:S
        {
            public override S play()
            {
                return new K();
            }
        }
    }
}
