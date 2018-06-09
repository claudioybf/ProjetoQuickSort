using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numeros = new int[9];
        int cont = 0;

        private void btnAdicionar(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    numeros[i] = num;
                    lblLista.Text = lblLista.Text + "-" + numeros[i];
                    cont++;
                    lblQtd.Text ="" + cont;

                    break;
                }
            }
        }

        public void QuickSort(int[] vetor, int inicio, int fim)
        {
            numeros = vetor;
            int baixo, alto, meio, pivo, repositorio;
            baixo = inicio;
            alto = fim;
            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                    baixo++;
                while (vetor[alto] > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > inicio)
                QuickSort(vetor, inicio, alto);
            if (baixo < fim)
                QuickSort(vetor, baixo, fim);
        }

        private void btnOrdenar(object sender, EventArgs e)
        {
            QuickSort(numeros, 0, numeros.Length - 1);

            lblListaOrdenada.Text = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                lblListaOrdenada.Text = lblListaOrdenada.Text + "-" + numeros[i];
            }
        }

        private void btnLimpar(object sender, EventArgs e)
        {
            lblLista.Text = "";
            cont = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != 0)
                {
                    numeros[i] = 0;
                }
            }
        }
    }
}
