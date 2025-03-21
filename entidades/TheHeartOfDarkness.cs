using DarkestCombat.itens.armas;
using DarkestCombat.mainclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkestCombat.entidades
{
    class TheHeartOfDarkness : Entidade
    {
        public TheHeartOfDarkness(string nome) : base(nome)
        {
            this.vidaMaxima = sistema.RolarDado(35, 20, 350);
            this.vidaAtual = vidaMaxima;
            this.moedas = moedas;
            this.classeArmadura = 22;
        }

        public int EldritchMagic()
        {
            return sistema.RolarDado(1, 20, 18);
        }
        public int PunctureDMG()
        {
            return sistema.RolarDado(10,6,15);
        }
        public int DissolutionDMG() 
        {
            return sistema.RolarDado(16, 10, 0);
        }
    }
}
