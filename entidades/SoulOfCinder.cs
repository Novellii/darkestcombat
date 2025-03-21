using DarkestCombat.itens.armas;
using DarkestCombat.itens.pocoes;
using DarkestCombat.mainclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DarkestCombat.entidades
{
    class SoulOfCinder : Entidade
    {
        public bool escudoLevantado {  get; set; }
        public EstusFlask estusFlask { get; set; }
        
        public SoulOfCinder(string nome) : base(nome)
        {
            this.vidaMaxima = sistema.RolarDado(19, 8, 190);
            this.vidaAtual = vidaMaxima;
            this.moedas = moedas;
            this.classeArmadura = 17;
            this.estusFlask = new EstusFlask(this);
            EstusFlask.quantidade = 12;
            this.escudoLevantado = false;
        }

        public void levantarEscudo()
        {
            MessageBox.Show("Escudo levantado.");
            this.classeArmadura += 3;
            escudoLevantado = true;
        }

        public void abaixarEscudo()
        {
            MessageBox.Show("O escudo foi abaixado");
            this.classeArmadura -= 3;
            escudoLevantado = false;
        }

    }
}
