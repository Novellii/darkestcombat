using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkestCombat.mainclasses
{
    internal interface Armas
    {
        public abstract string PrintarValores();
        public abstract int Acertar();
        public abstract int DanoArma();
    }
}
