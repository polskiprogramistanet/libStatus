using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libStatus.Statusy;

namespace libStatus
{
    public class Status:Statusy.IObserver
    {
        protected  EnumStatus _state { get; set; }
        private StatusAbstract Gotowy = new Ready();
        private StatusAbstract Zablokowany = new Block();
        private StatusAbstract Tankuje = new TankProgress();
         

        public Status()
        {
            Gotowy.AddObserver(this);
            Zablokowany.AddObserver(this);
            Tankuje.AddObserver(this);
        }
        public EnumStatus GetStatus(byte S1, byte S0)
        {
            // zgodnie z chain of Responsiblity Ustawiam kolejny łańcuch do sprawdzenia warunku
            Gotowy.SetSuccesor(Zablokowany);
            Zablokowany.SetSuccesor(Tankuje);

            Gotowy.StatusRequest(S1, S0);   //rozpoczynam spraawdzanie zapytania o status

            return _state;
        }

        public void Update(EnumStatus status)
        {
            _state = status;    
        }
    }

    public enum EnumStatus
    {//enumerator z możliwymi statusami
        BrakDanych = 0,
        Gotowy = 1,
        Tankuje = 2,
        Zablokowany = 3,
        DoRozliczenia = 4,
        Rozliczany = 5,
        Podniesiony = 6,
        ZablokowanyPodniesiony = 7,
        Rezerwacja = 8

    }
}
