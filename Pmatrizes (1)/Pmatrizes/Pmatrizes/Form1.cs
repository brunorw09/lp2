using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar;

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número ", "Entrada de Dados");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Dados inválidos");
                    i--;
                }
            }
            auxiliar = "";
            Array.Reverse(vetor);
            auxiliar = string.Join("\n", vetor);
            MessageBox.Show("Inverso :" + auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList Lista = new ArrayList() { "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otavio", "Marcelo", "Pedro", "Thais" };
            Lista.Remove("Otavio");
            foreach (string nome in Lista)
            {
                MessageBox.Show($"Nome: {nome}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double[,] alunosNotas = new Double[20, 3];
            string auxiliar, notas;
            double media;
            double tam = alunosNotas.Length;

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox($"Digite a nota do aluno {i + 1} na prova {j + 1}", "Entrada de Dados");

                    if (!double.TryParse(auxiliar, out alunosNotas[i, j]))
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }

                    if (auxiliar == "")
                    {
                        break;
                    }
                }
            }

            notas = "";

            for (int k = 0; k < tam; k++)
            {
                media = (alunosNotas[k, 0] + alunosNotas[k, 1] + alunosNotas[k, 2]) / 3;
                notas += $"Media do Aluno {k + 1}: {media.ToString("N2")}.\n";
            }

            MessageBox.Show(notas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] nomes = new String[10];
            int[] nomeLetras = new int[10];
            int isEspaco;
            char[] letraAletra;

            string listaNomes = "";

            for (int i = 0; i < 10; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o {i + 1}º nome.", "Entrada de Dados");

                letraAletra = nomes[i].ToCharArray();

                isEspaco = 0;

                for (int j = 0; j < nomes[i].Length; j++)
                {
                    if (Char.IsWhiteSpace(letraAletra[j]))
                    {
                        isEspaco++;
                    }
                }

                nomeLetras[i] = nomes[i].Length - isEspaco;
            }

            for (int k = 0; k < 10; k++)
            {
                listaNomes += $"O nome {nomes[k]} tem {nomeLetras[k]} letras.\n";
            }

            MessageBox.Show(listaNomes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Exercicio5"] != null)
            {
                Application.OpenForms["Exercicio5"]?.BringToFront();
            }
            else
            {
                Exercicio5 objform = new Exercicio5();
                objform.Show();
            }
        }

    } 
}
