using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libStatus.Statusy
{
    class Block:StatusAbstract
    {
        private EnumStatus status;
        public override void InfoToObserver()
        {
            this.obserwator.Update(status);
        }
        public override void StatusRequest(byte S1, byte S0)
        {
            if (S1 == 30 && S0 == 32)
            {
                
                status = EnumStatus.Zablokowany;

                this.InfoToObserver();
            }
            else if (successor != null)
            {
                successor.StatusRequest(S1, S0);
            }
        }
    }
}
