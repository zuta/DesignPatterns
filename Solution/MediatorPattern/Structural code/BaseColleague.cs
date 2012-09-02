using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural_code
{
    abstract class BaseColleague
    {
        protected Mediator mediator;

        public BaseColleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}
