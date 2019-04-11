using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libStatus.Statusy
{
    abstract class StatusAbstract : IWatched
    {
        protected StatusAbstract successor;
        protected IObserver obserwator = null;

        public void AddObserver(IObserver o)
        {
            this.obserwator = o;
        }

        public abstract void InfoToObserver();
        
        public void SetSuccesor(StatusAbstract successor)
        {
            this.successor = successor;
        }

        public abstract void StatusRequest(byte S1, byte S0);
    }
}
