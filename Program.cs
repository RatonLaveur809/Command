using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            Invoker invoker = new Invoker();
            int n;

            while(true)
            {
                Console.WriteLine("Что делать с датой?");
                Console.WriteLine("1 - вывести в разных форматах");
                Console.WriteLine("2 - вычислить расстояние между двумя датами в днях");
                Console.WriteLine("3 - вычислить день недели");
                n=int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Format format = new Format(date);
                            invoker.setCommand(format);
                            invoker.doIt();
                            break;
                        }
                    case 2:
                        {
                            Distance dist = new Distance(date);
                            invoker.setCommand(dist);
                            invoker.doIt();
                            break;
                        }
                    case 3:
                        {
                            GetDay day = new GetDay(date);
                            invoker.setCommand(day);
                            invoker.doIt();
                            break;
                        }
                }
                Console.ReadKey();
            }            
        }
    }
}
