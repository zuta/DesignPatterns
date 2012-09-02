using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural_code
{
    class Mediator
    {
        private ColleagueA colleagueA;
        private ColleagueB colleagueB;

        public ColleagueA ColleagueA
        {
            get
            {
                return colleagueA;
            }
            set
            {
                colleagueA = value;
            }
        }

        public ColleagueB ColleagueB
        {
            get
            {
                return colleagueB;
            }
            set
            {
                colleagueB = value;
            }
        }

        public Mediator()
        {
        }

        public void Send(string message, BaseColleague fromColleague)
        {
            if (fromColleague == colleagueA)
            {
                colleagueB.Notify(message);
            }
            else
            {
                colleagueA.Notify(message);
            }
        }
    }
}
