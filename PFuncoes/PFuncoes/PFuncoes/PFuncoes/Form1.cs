using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sem retorno e sem parametro
        void Soma()
        {
            double resultado = 5 + 6;
            MessageBox.Show(resultado.ToString());
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Soma();
        }

        //com retorno e sem parametro
        Double Soma1()
        {
            double Resultado = 5 + 6;
            return Resultado; //return 5 + 6
        }

        private void btnSoma1_Click(object sender, EventArgs e)
        {
            double retorno = Soma1();
            MessageBox.Show(retorno.ToString());
            //ou
            //MessageBox.Show(Soma1().ToString());
        }

        //sem retorno com parametro

        void soma2(double x, double y)
        {
            x = x * 10;
            double resultado = x + y;
            MessageBox.Show(resultado.ToString());
        }

        private void btnSoma2_Click(object sender, EventArgs e)
        {
            double numero1 = 5; 
            double numero2 = 6;
            soma2(numero1, numero2);

            MessageBox.Show(numero1.ToString());
        }
        void Soma3(ref double x, double y)
        {
            x = x * 10;
            y = y * 10;
            double resultado = x + y; //50+16
            MessageBox.Show(resultado.ToString());
        }

        private void btnSoma3_Click(object sender, EventArgs e)
        {
            double numero1 = 5;
            double numero2 = 6;
            Soma3(ref numero1, numero2);
            MessageBox.Show(numero1.ToString());
            MessageBox.Show(numero2.ToString());
        }

        double soma4(double x, double y, out double resultadoDobro)
        {
            resultadoDobro = (x + y) * 2;
            return x + y;
        }

        private void btnSoma4_Click(object sender, EventArgs e)
        {
            double r = 0;
            double numero1 = 5;
            double numero2 = 6;

            MessageBox.Show(soma4(numero1, numero2, out r).ToString());
            MessageBox.Show(r.ToString());
        }

        double Soma5(double x, double y, double z=0)
        {
            if (z>0)
            {
                return (x + y + z) / 2;
            }
            else
            {
                return (x + y) / 2;
            }
        }

        private void btnSoma5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sem 3° parâmetro :" +Soma5(5,6));
            MessageBox.Show("com 3° parâmetro :" + Soma5(5, 6, 10));
        }

        private void btnFormatacao1_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            MessageBox.Show("Data Curta=" + data.ToShortDateString());
            MessageBox.Show("Hora extensa" + data.ToLongTimeString());
            MessageBox.Show("com formatos" + data.ToString("dd/MM/yyyy"));

            DateTime data2 = Convert.ToDateTime("02/10/2025");

            double dias = data.Subtract(data2).TotalDays;
            MessageBox.Show("Diferença dias=" +dias);

            DateTime novaData = data2.AddDays(10);

            MessageBox.Show("Nova data=" +novaData);
        }
    }
}
