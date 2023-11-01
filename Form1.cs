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
        float kmRodado = 0;
        float KmAutonomia = 0;
        float QtdCombustivel = 0;
        double valorCombustivel, custoCombustivel;
         
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

        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           kmRodado= float.Parse(txtBoxDistanciaKM.Text);
            float kmDobrado = 0;
            if (checkBoxIdaVolta.Checked== false)
            {
                kmDobrado = kmRodado * 1;
            }
            else if (checkBoxIdaVolta.Checked) {
                kmDobrado = kmRodado * 2;
            }
            //consumo do combustível
            QtdCombustivel = kmDobrado / float.Parse(txtBoxAutonomiaCombustivel.Text);

            //custo do combustível
           custoCombustivel = double.Parse(txtBoxValorCombustivelPorLt.Text)* QtdCombustivel;

            txtBoxDespesaCombustivel.Text = custoCombustivel.ToString();

            txtBoxTotal.Text = Convert.ToString(custoCombustivel * int.Parse(comboBoxTabela.Text));
        
            txtBoxConsumoCombustivel.Text=custoCombustivel.ToString();  
            txtBoxKmRodado.Text = kmDobrado.ToString();
            txtBoxCustoKM.Text = Convert.ToString(float.Parse(txtBoxKmRodado.Text) / kmDobrado);
        }
    }
}
