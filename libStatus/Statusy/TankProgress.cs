using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libStatus.Statusy
{
    class TankProgress:StatusAbstract
    {
        private EnumStatus status;
        public override void InfoToObserver()
        {
            this.obserwator.Update(status);
        }
        public override void StatusRequest(byte S1, byte S0)
        {
            if (S1 == 30 && S0 == 30)
            {

                status = EnumStatus.Tankuje;

                this.InfoToObserver();
            }
            else if (successor != null)
            {
                successor.StatusRequest(S1, S0);
            }
        }
    }
}
