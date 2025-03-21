using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkestCombat.mainclasses
{
    internal class Itens
    {
        public static int quantidade = 1;
        public String nomeItem { get; set; }
        public int moedas { get; set; }
        public Entidade usuario { get; set; }
        public Sistema sistema = new Sistema();
        public Itens(Entidade usuario)
        {
            this.usuario = usuario;
            this.nomeItem = nomeItem;
            this.moedas = moedas;
        }
    }
}
