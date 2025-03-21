using DarkestCombat.mainclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkestCombat.itens.pocoes
{
    internal class EstusFlask : Itens, Pocoes
    {
        public EstusFlask(Entidade usuario) : base(usuario)
        {
            this.nomeItem = "Poção de Vida";
            this.moedas = 200;
        }

        public void BeberPocao()
        {
            if (EstusFlask.quantidade > 0)
            {
                usuario.RecuperarVida(sistema.RolarDado(10, 4, 20));
                EstusFlask.quantidade -= 1;
            } else
            {
                MessageBox.Show("Acabaram as poções!");
            }
        }

        public int RetornaQuant()
        {
            int quant = EstusFlask.quantidade;
            return quant;
        }



    }

}
