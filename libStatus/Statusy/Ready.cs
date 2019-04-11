using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libStatus.Statusy
{
    class Ready : StatusAbstract
    {
        private EnumStatus status;
        public override void InfoToObserver()
        {
            this.obserwator.Update(status); //zgodnie ze wzorcem Obserwator następuje update statusu
        }
        public override void StatusRequest(byte S1, byte S0)
        {
            if (S1 == 30 && S0==31)//sprawdzanie warunku
            {
               
                status = EnumStatus.Gotowy;

                this.InfoToObserver(); 
            }
            else if (successor != null)
            {
                successor.StatusRequest(S1, S0);
            }
        }

    }
}
