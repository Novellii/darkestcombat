using DarkestCombat.mainclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkestCombat.itens.armas
{
    class CoiledSword : Itens, Armas
    {
        public CoiledSword(Entidade usuario) : base(usuario)
        {
            this.nomeItem = "Espada Infernal";
            this.moedas = 2000;
        }

        int Armas.Acertar()
        {
            return sistema.RolarDado(1, 20, 17);
        }

        int Armas.DanoArma()
        {
            return sistema.RolarDado(12, 6, 15); 
        }

        string Armas.PrintarValores()
        {
            return nomeItem;
        }
    }
}
