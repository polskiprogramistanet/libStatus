using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libStatus;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Aplikacja testująca bibliotekę dekodującą status sterownika Petromis 3000
             Sterownik przesyła dwa bajty statusu (bajt S1 i bajt S0) do biblioteki libStatus
             i otrzymujemy informację w postaci enumatora o faktycznym stanie urządzenia.
             spodziewane wartości:
             - S0=30 S1=31 : Gotowy
             - S0=30 S1=32 : Zablokowany
             - S0=30 S1=30 : Tankuje
             W przykładzie wykorzystałem dwa wzorce 
             - chain of Responsiblity - w celu porównania wartości wchodzących i podjęcia decyzji
             - observer (obserwator) do uaktualnienia statusu na podstawie przekazanych bajtów
             */
            Status state = new Status();    //Inicjalizacja biblioteki
            Console.WriteLine(state.GetStatus(30, 31));
            Console.WriteLine(state.GetStatus(30, 30));
            Console.WriteLine(state.GetStatus(30, 32));


            Console.ReadKey();
        }
    }
}
