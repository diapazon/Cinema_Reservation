using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Seance
    {
        public static List<Seance> Seanslar = new List<Seance>();
        DateTime vaxt = new DateTime();

        public Seance(DateTime _vaxt)
        {
            vaxt = _vaxt;
            Seanslar.Add(this);

        }
    }
}
