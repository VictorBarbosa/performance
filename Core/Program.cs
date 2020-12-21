using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
          var startTime  = DateTime.Now;
           Counter();
           var endtime  = DateTime.Now;
           var total = endtime - startTime;
           Console.WriteLine("Start {0}",startTime);  
           Console.WriteLine("End {0}",endtime);  
           Console.WriteLine("Total {0}",total);   
        }
       static void Counter()
       {
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);   
            }
        }

    }
}
