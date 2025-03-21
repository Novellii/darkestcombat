using DarkestCombat.mainclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkestCombat.itens.armas
{
    class CoiledSpear : Itens, Armas
    {
        public CoiledSpear(Entidade usuario) : base(usuario)
        {
            this.nomeItem = "Lança Infernal";
            this.moedas = 2000;
        }

        int Armas.Acertar()
        {
            return sistema.RolarDado(1, 20, 17);
        }

        int Armas.DanoArma()
        {
            return sistema.RolarDado(6, 6, 0) + sistema.RolarDado(3, 10, 15);
        }

        string Armas.PrintarValores()
        {
            return nomeItem;
        }
    }
}
