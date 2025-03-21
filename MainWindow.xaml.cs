using DarkestCombat.entidades;
using DarkestCombat.itens.armas;
using DarkestCombat.itens.pocoes;
using DarkestCombat.mainclasses;
using System;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DarkestCombat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sistema sistema = new Sistema();
        SoulOfCinder Jogador = new SoulOfCinder("Artorias");
        TheHeartOfDarkness Inimigo = new TheHeartOfDarkness("Coração da Escuridão");
        CoiledSpear Lança;
        CoiledSword Espada;
        public MainWindow()
        {
            InitializeComponent();
            this.Lança = new CoiledSpear(Jogador);
            this.Espada = new CoiledSword(Jogador);
            Jogador.EquiparArma(Espada);

            VidaPlayer.Maximum = Jogador.vidaMaxima;
            VidaPlayer.Minimum = 0;
            VidaPlayer.Value = Jogador.vidaAtual;

            VidaAtualConteudo.Content = Jogador.vidaAtual;
            VidaMaximaConteudo.Content = Jogador.vidaMaxima;
            DefesaConteudo.Content = Jogador.classeArmadura;
            FrascosQuant.Content = Jogador.estusFlask.RetornaQuant();

            VidaInimigo.Maximum = Inimigo.vidaMaxima;
            VidaInimigo.Minimum = 0;
            VidaInimigo.Value = Inimigo.vidaAtual;
            
        }

        private void AtackButton(object sender, RoutedEventArgs e)
        {
            int Acerto = sistema.VerificarAcerto(Jogador.armaEquipada.Acertar(), Inimigo);
            int Dano = Jogador.armaEquipada.DanoArma();
            if (Jogador.escudoLevantado == true)
            {
                Dano = (int)(Dano * 0.8);
            }

            if (Acerto == 1)
            {
                Inimigo.TomarDano(Dano);
            } else if (Acerto == -1)
            {
                Jogador.TomarDano(Dano);
            } else
            {
                MessageBox.Show("Você errou o ataque!");
            }

            TurnoInimigo();    
        }

        public void TurnoInimigo()
        {
            Random random = new Random();
            int resultado = random.Next(0, 3);
            var ataque = Inimigo.EldritchMagic();
            if (resultado == 0) { ataque = Inimigo.EldritchMagic(); }
            else if (resultado == 1) { ataque = Inimigo.PunctureDMG(); }
            else if (resultado == 2) { ataque = Inimigo.DissolutionDMG(); }
            int Acerto = sistema.VerificarAcerto(ataque, Jogador);
            VidaInimigo.Value = Inimigo.vidaAtual;

            if (Acerto == 1)
            {
                Jogador.TomarDano(ataque);
            } else if (Acerto == -1)
            {
                Inimigo.TomarDano(ataque);
            }

            AtualizarValores();
        }

        public void AtualizarValores()
        {
            VidaAtualConteudo.Content = Jogador.vidaAtual;
            VidaPlayer.Value = Jogador.vidaAtual;
            VidaInimigo.Value = Inimigo.vidaAtual;

            if (Inimigo.vidaAtual == 0)
            {
                MessageBox.Show("Você venceu!");
                this.Close();
            }
            else
            {
                VidaAtualConteudo.Content = Jogador.vidaAtual;
                VidaPlayer.Value = Jogador.vidaAtual;
                if (Jogador.vidaAtual == 0)
                {
                    MessageBox.Show("Você perdeu!");
                    this.Close();
                }
            }
        }

        private void VidaPlayer_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }


        private void TrocarLanca(object sender, RoutedEventArgs e)
        {
            if (Jogador.armaEquipada.PrintarValores() == "Lança Infernal")
            {
                MessageBox.Show("Esta arma já está equipada!");
            }
            else
            {
                Jogador.EquiparArma(Lança);
                MessageBox.Show("A arma equipada é a " + Jogador.armaEquipada.PrintarValores());
            }
        }

        private void TrocarEspada(object sender, RoutedEventArgs e)
        {
            if (Jogador.armaEquipada.PrintarValores() == "Espada Infernal")
            {
                MessageBox.Show("Esta arma já está equipada!");
            } else
            {
                Jogador.EquiparArma(Espada);
                MessageBox.Show("A arma equipada é a " + Jogador.armaEquipada.PrintarValores());
            }
        }

        private void DefenderButton(object sender, RoutedEventArgs e)
        {
            if (Jogador.escudoLevantado == true)
            {
                Jogador.abaixarEscudo();
            }
            else
            {
                Jogador.levantarEscudo();
            }
            DefesaConteudo.Content = Jogador.classeArmadura;
        }

        private void CurarButton(object sender, RoutedEventArgs e)
        {
            Jogador.estusFlask.BeberPocao();
            VidaAtualConteudo.Content = Jogador.vidaAtual;
            VidaPlayer.Value = Jogador.vidaAtual;
            FrascosQuant.Content = Jogador.estusFlask.RetornaQuant();
        }
    }
}