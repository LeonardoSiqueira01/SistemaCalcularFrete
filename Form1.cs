using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCalcularFrete
{
    public partial class Form1 : Form
    {
        float kmRodada = 0;
        float KmAutonomia = 0;
        float custoCombustivel = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxVeiculo_Leave(object sender, EventArgs e)
        {
            if (txtBoxVeiculo.Text == "carro")
            {
                pictureBoxImgVeiculo.Image = SistemaCalcularFrete.Properties.Resources.Carro;
            }
            else if (txtBoxVeiculo.Text == "moto")
            {
                pictureBoxImgVeiculo.Image = SistemaCalcularFrete.Properties.Resources.Moto;
            }
            else if (txtBoxVeiculo.Text == "caminhão")
            {
                pictureBoxImgVeiculo.Image = SistemaCalcularFrete.Properties.Resources.caminhao;
            }
            else if (txtBoxVeiculo.Text == "caminhao")
            {
                pictureBoxImgVeiculo.Image = SistemaCalcularFrete.Properties.Resources.caminhao;
            }
            else { 
                MessageBox.Show("Opcao invalida!Escolha Caminhão, carro ou moto");
                txtBoxVeiculo.Text = "";
                txtBoxVeiculo.Focus();
            }
        }

        private void txtBoxDistanciaKM_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxIdaVolta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           kmRodada= float.Parse(txtBoxDistanciaKM.Text);
            float kmDobrado = 0;
            if (checkBoxIdaVolta.Checked)
            {
                kmDobrado = kmRodada * 2;
            }
            else {
                kmDobrado = kmRodada * 1;
            }

            custoCombustivel = float.Parse(txtBoxAutonomiaCombustivel.Text) * kmRodada;
        }
    }
}
