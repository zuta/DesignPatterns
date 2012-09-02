using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural_code
{
    class ColleagueB : BaseColleague
    {
        public ColleagueB(Mediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("ColleagueB got message : {0}", message);
        }
    }
}
