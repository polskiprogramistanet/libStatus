using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libStatus.Statusy
{
    interface IWatched
    {
        void AddObserver(IObserver o);
        void InfoToObserver();
    }
}
