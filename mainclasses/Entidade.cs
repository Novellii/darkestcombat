using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkestCombat.mainclasses
{
    internal class Entidade
    {
        public string nome { set; get; }
        public int vidaMaxima { set; get; }
        public int vidaAtual { set; get; }
        public int moedas { set; get; }
        public int classeArmadura { set; get; }

        public Sistema sistema = new Sistema();

        public Armas armaEquipada;

            public Entidade(string nome)
            {
                this.nome = nome;
            }

            public void TomarDano(int DMG)
            {
                this.vidaAtual -= DMG;
                if (vidaAtual < 0)
                {
                    vidaAtual = 0;
                }
        }

            public void EquiparArma(Armas a)
            {
                this.armaEquipada = a;
            }

        public void RecuperarVida(int vida)
        {
            if (vidaAtual + vida <= vidaMaxima)
            {
                vidaAtual += vida;
            } else
            {
                vidaAtual = vidaMaxima;
            }
        }

}
}
