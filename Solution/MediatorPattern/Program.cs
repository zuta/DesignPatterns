using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Structural_code;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using structural code : ");
            Console.WriteLine();

            Mediator mediator = new Mediator();

            ColleagueA colleagueA = new ColleagueA(mediator);
            ColleagueB colleagueB = new ColleagueB(mediator);

            mediator.ColleagueA = colleagueA;
            mediator.ColleagueB = colleagueB;

            colleagueA.Send("Hi! I'm colleagueA");
            colleagueB.Send("Hi! I'm colleagueB");

            Console.ReadLine();

            Console.WriteLine("Using real-world code : ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
