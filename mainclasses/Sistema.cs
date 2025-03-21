using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DarkestCombat.mainclasses
{
    internal class Sistema
    {
        public int RolarDado(int quantidade, int valor, int soma)
        {
            Random random = new Random();
            int resultado = 0;

            for (int i = 0; i < quantidade; i++)
            {
                resultado = random.Next(1, valor + 1);
                if (quantidade == 1 && valor == 20 && resultado == 1)
                {
                    MessageBox.Show("Erro Crítico!");
                    soma = 0;
                }
                else
                {
                    soma += resultado;
                }
            }
            return soma;
        }


        public int VerificarAcerto(int Acerto, Entidade entidadeAcertada)
        {
            if (Acerto == 0)
            {
                return -1;
            } 

            if (Acerto >= entidadeAcertada.classeArmadura)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
