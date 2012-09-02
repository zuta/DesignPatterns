using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural_code
{
    class ColleagueA : BaseColleague
    {
        public ColleagueA(Mediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("ColleagueA got message : {0}", message);
        }
    }
}
