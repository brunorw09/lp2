using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmatrizes
{
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string[] gabarito = { "A", "B", "C", "D", "E", "B", "C", "A", "D", "E" };
            String[,] alunoMatriz = new string[10, 10];
            string[] opcoesValidas = { "A", "B", "C", "D", "E" };
            int i, j;
            string finalNotas = "";


            // alunos
            for (i = 0; i < 10; i++)
            {
                // respostas
                for (j = 0; j < 10; j++)
                {
                    string resposta = "";
                    resposta = Interaction.InputBox($"Insira a resposta da questão {j + 1}", $"Aluno {i + 1}").ToUpper();

                    if (!opcoesValidas.Contains(resposta))
                    {
                        MessageBox.Show("Opção inválida, escolha entre A, B, C, D ou E");
                        j--;
                    }
                    else
                    {
                        alunoMatriz[i, j] = resposta;
                    }

                }
            }

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (alunoMatriz[i, j] == gabarito[j])
                        finalNotas += $"O Aluno {i + 1} acertou a questão {j + 1}: era {gabarito[j]} escolheu {alunoMatriz[i, j]}\n";
                    else
                        finalNotas += $"O Aluno {i + 1} errou a questão {j + 1}: era {gabarito[j]} escolheu {alunoMatriz[i, j]}\n";
                }
            }

            lstRespostas.Items.AddRange(finalNotas.Split('\n'));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
