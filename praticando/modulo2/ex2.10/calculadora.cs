using System;
using System.Windows.Forms;

namespace CalculadorPlus
{
    public partial class Form1 : Form
    {

        double valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtValor.Text, out valor))
            {
                listaValores.Items.Add(valor);
            }
            else
            {
                MessageBox.Show("Digite um valor válido");
            }
        }

        private void btnKilometro_Click(object sender, EventArgs e)
        {
            double resultado = valor / 1000;

            lblResultado.Text = 
            "Resultado: " + resultado + " km";
        }

        private void btnHectometro_Click(object sender, EventArgs e)
        {
            double resultado = valor / 100;

            lblResultado.Text =
            "Resultado: " + resultado + " hm";
        }

        private void btnCentimetro_Click(object sender, EventArgs e)
        {
            double resultado = valor * 100;

            lblResultado.Text =
            "Resultado: " + resultado + " cm";
        }