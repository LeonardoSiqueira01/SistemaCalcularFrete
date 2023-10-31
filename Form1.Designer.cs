namespace SistemaCalcularFrete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxVeiculo = new System.Windows.Forms.TextBox();
            this.txtBoxLocalidade = new System.Windows.Forms.TextBox();
            this.txtBoxAutonomiaCombustivel = new System.Windows.Forms.TextBox();
            this.txtBoxDistanciaKM = new System.Windows.Forms.TextBox();
            this.comboBoxTabela = new System.Windows.Forms.ComboBox();
            this.checkBoxIdaVolta = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblDistanciaKM = new System.Windows.Forms.Label();
            this.lblAutonomiaCombustivel = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblConsumoCombustivel = new System.Windows.Forms.Label();
            this.lblKmRodado = new System.Windows.Forms.Label();
            this.lblCustoKm = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDespesaCombustivel = new System.Windows.Forms.Label();
            this.txtBoxConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.txtBoxDespesaCombustivel = new System.Windows.Forms.TextBox();
            this.txtBoxKmRodado = new System.Windows.Forms.TextBox();
            this.txtBoxCustoKM = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.pictureBoxImgVeiculo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA CÁLCULO FRETE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTabela);
            this.panel1.Controls.Add(this.lblAutonomiaCombustivel);
            this.panel1.Controls.Add(this.lblDistanciaKM);
            this.panel1.Controls.Add(this.lblLocalidade);
            this.panel1.Controls.Add(this.lblVeiculo);
            this.panel1.Controls.Add(this.checkBoxIdaVolta);
            this.panel1.Controls.Add(this.comboBoxTabela);
            this.panel1.Controls.Add(this.txtBoxDistanciaKM);
            this.panel1.Controls.Add(this.txtBoxAutonomiaCombustivel);
            this.panel1.Controls.Add(this.txtBoxLocalidade);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.txtBoxVeiculo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 212);
            this.panel1.TabIndex = 1;
            // 
            // txtBoxVeiculo
            // 
            this.txtBoxVeiculo.Location = new System.Drawing.Point(10, 55);
            this.txtBoxVeiculo.Name = "txtBoxVeiculo";
            this.txtBoxVeiculo.Size = new System.Drawing.Size(189, 20);
            this.txtBoxVeiculo.TabIndex = 1;
            this.txtBoxVeiculo.Leave += new System.EventHandler(this.txtBoxVeiculo_Leave);
            // 
            // txtBoxLocalidade
            // 
            this.txtBoxLocalidade.Location = new System.Drawing.Point(205, 55);
            this.txtBoxLocalidade.Name = "txtBoxLocalidade";
            this.txtBoxLocalidade.Size = new System.Drawing.Size(189, 20);
            this.txtBoxLocalidade.TabIndex = 2;
            // 
            // txtBoxAutonomiaCombustivel
            // 
            this.txtBoxAutonomiaCombustivel.Location = new System.Drawing.Point(10, 137);
            this.txtBoxAutonomiaCombustivel.Name = "txtBoxAutonomiaCombustivel";
            this.txtBoxAutonomiaCombustivel.Size = new System.Drawing.Size(137, 20);
            this.txtBoxAutonomiaCombustivel.TabIndex = 4;
            // 
            // txtBoxDistanciaKM
            // 
            this.txtBoxDistanciaKM.Location = new System.Drawing.Point(400, 55);
            this.txtBoxDistanciaKM.Name = "txtBoxDistanciaKM";
            this.txtBoxDistanciaKM.Size = new System.Drawing.Size(109, 20);
            this.txtBoxDistanciaKM.TabIndex = 3;
            this.txtBoxDistanciaKM.TextChanged += new System.EventHandler(this.txtBoxDistanciaKM_TextChanged);
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.FormattingEnabled = true;
            this.comboBoxTabela.Location = new System.Drawing.Point(205, 137);
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTabela.TabIndex = 5;
            this.comboBoxTabela.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxIdaVolta
            // 
            this.checkBoxIdaVolta.AutoSize = true;
            this.checkBoxIdaVolta.Location = new System.Drawing.Point(413, 141);
            this.checkBoxIdaVolta.Name = "checkBoxIdaVolta";
            this.checkBoxIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.checkBoxIdaVolta.TabIndex = 6;
            this.checkBoxIdaVolta.Text = "Ida / Volta";
            this.checkBoxIdaVolta.UseVisualStyleBackColor = true;
            this.checkBoxIdaVolta.CheckedChanged += new System.EventHandler(this.checkBoxIdaVolta_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(10, 186);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(10, 39);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(47, 13);
            this.lblVeiculo.TabIndex = 8;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(202, 39);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 9;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblDistanciaKM
            // 
            this.lblDistanciaKM.AutoSize = true;
            this.lblDistanciaKM.Location = new System.Drawing.Point(397, 39);
            this.lblDistanciaKM.Name = "lblDistanciaKM";
            this.lblDistanciaKM.Size = new System.Drawing.Size(73, 13);
            this.lblDistanciaKM.TabIndex = 10;
            this.lblDistanciaKM.Text = "Distância KM:";
            // 
            // lblAutonomiaCombustivel
            // 
            this.lblAutonomiaCombustivel.AutoSize = true;
            this.lblAutonomiaCombustivel.Location = new System.Drawing.Point(10, 121);
            this.lblAutonomiaCombustivel.Name = "lblAutonomiaCombustivel";
            this.lblAutonomiaCombustivel.Size = new System.Drawing.Size(137, 13);
            this.lblAutonomiaCombustivel.TabIndex = 11;
            this.lblAutonomiaCombustivel.Text = "Autonomia do Combustível:";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(205, 121);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(43, 13);
            this.lblTabela.TabIndex = 12;
            this.lblTabela.Text = "Tabela:";
            // 
            // lblConsumoCombustivel
            // 
            this.lblConsumoCombustivel.AutoSize = true;
            this.lblConsumoCombustivel.Location = new System.Drawing.Point(9, 299);
            this.lblConsumoCombustivel.Name = "lblConsumoCombustivel";
            this.lblConsumoCombustivel.Size = new System.Drawing.Size(131, 13);
            this.lblConsumoCombustivel.TabIndex = 13;
            this.lblConsumoCombustivel.Text = "Consumo de Combustível:";
            // 
            // lblKmRodado
            // 
            this.lblKmRodado.AutoSize = true;
            this.lblKmRodado.Location = new System.Drawing.Point(12, 358);
            this.lblKmRodado.Name = "lblKmRodado";
            this.lblKmRodado.Size = new System.Drawing.Size(62, 13);
            this.lblKmRodado.TabIndex = 14;
            this.lblKmRodado.Text = "KM rodado:";
            // 
            // lblCustoKm
            // 
            this.lblCustoKm.AutoSize = true;
            this.lblCustoKm.Location = new System.Drawing.Point(119, 358);
            this.lblCustoKm.Name = "lblCustoKm";
            this.lblCustoKm.Size = new System.Drawing.Size(74, 13);
            this.lblCustoKm.TabIndex = 15;
            this.lblCustoKm.Text = "Custo por KM:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(299, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // lblDespesaCombustivel
            // 
            this.lblDespesaCombustivel.AutoSize = true;
            this.lblDespesaCombustivel.Location = new System.Drawing.Point(299, 299);
            this.lblDespesaCombustivel.Name = "lblDespesaCombustivel";
            this.lblDespesaCombustivel.Size = new System.Drawing.Size(129, 13);
            this.lblDespesaCombustivel.TabIndex = 17;
            this.lblDespesaCombustivel.Text = "Despesa de Combustível:";
            // 
            // txtBoxConsumoCombustivel
            // 
            this.txtBoxConsumoCombustivel.Location = new System.Drawing.Point(7, 315);
            this.txtBoxConsumoCombustivel.Name = "txtBoxConsumoCombustivel";
            this.txtBoxConsumoCombustivel.Size = new System.Drawing.Size(259, 20);
            this.txtBoxConsumoCombustivel.TabIndex = 13;
            // 
            // txtBoxDespesaCombustivel
            // 
            this.txtBoxDespesaCombustivel.Location = new System.Drawing.Point(302, 315);
            this.txtBoxDespesaCombustivel.Name = "txtBoxDespesaCombustivel";
            this.txtBoxDespesaCombustivel.Size = new System.Drawing.Size(189, 20);
            this.txtBoxDespesaCombustivel.TabIndex = 18;
            // 
            // txtBoxKmRodado
            // 
            this.txtBoxKmRodado.Location = new System.Drawing.Point(12, 375);
            this.txtBoxKmRodado.Name = "txtBoxKmRodado";
            this.txtBoxKmRodado.Size = new System.Drawing.Size(89, 20);
            this.txtBoxKmRodado.TabIndex = 19;
            this.txtBoxKmRodado.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtBoxCustoKM
            // 
            this.txtBoxCustoKM.Location = new System.Drawing.Point(122, 375);
            this.txtBoxCustoKM.Name = "txtBoxCustoKM";
            this.txtBoxCustoKM.Size = new System.Drawing.Size(144, 20);
            this.txtBoxCustoKM.TabIndex = 20;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(302, 375);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(189, 20);
            this.txtBoxTotal.TabIndex = 21;
            // 
            // pictureBoxImgVeiculo
            // 
            this.pictureBoxImgVeiculo.Location = new System.Drawing.Point(517, 250);
            this.pictureBoxImgVeiculo.Name = "pictureBoxImgVeiculo";
            this.pictureBoxImgVeiculo.Size = new System.Drawing.Size(280, 168);
            this.pictureBoxImgVeiculo.TabIndex = 2;
            this.pictureBoxImgVeiculo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCalcularFrete.Properties.Resources.fiorino_moto_caminhao;
            this.pictureBox1.Location = new System.Drawing.Point(515, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxCustoKM);
            this.Controls.Add(this.txtBoxKmRodado);
            this.Controls.Add(this.txtBoxDespesaCombustivel);
            this.Controls.Add(this.txtBoxConsumoCombustivel);
            this.Controls.Add(this.lblDespesaCombustivel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCustoKm);
            this.Controls.Add(this.lblKmRodado);
            this.Controls.Add(this.lblConsumoCombustivel);
            this.Controls.Add(this.pictureBoxImgVeiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxIdaVolta;
        private System.Windows.Forms.ComboBox comboBoxTabela;
        private System.Windows.Forms.TextBox txtBoxDistanciaKM;
        private System.Windows.Forms.TextBox txtBoxAutonomiaCombustivel;
        private System.Windows.Forms.TextBox txtBoxLocalidade;
        private System.Windows.Forms.TextBox txtBoxVeiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxImgVeiculo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblAutonomiaCombustivel;
        private System.Windows.Forms.Label lblDistanciaKM;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblConsumoCombustivel;
        private System.Windows.Forms.Label lblKmRodado;
        private System.Windows.Forms.Label lblCustoKm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDespesaCombustivel;
        private System.Windows.Forms.TextBox txtBoxConsumoCombustivel;
        private System.Windows.Forms.TextBox txtBoxDespesaCombustivel;
        private System.Windows.Forms.TextBox txtBoxKmRodado;
        private System.Windows.Forms.TextBox txtBoxCustoKM;
        private System.Windows.Forms.TextBox txtBoxTotal;
    }
}

