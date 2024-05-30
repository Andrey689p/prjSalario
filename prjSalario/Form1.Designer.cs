namespace prjSalario
{
    partial class frmSalario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalario));
            this.lbltiulo = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lblSaAtual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbEscolaridade = new System.Windows.Forms.GroupBox();
            this.rdbG3 = new System.Windows.Forms.RadioButton();
            this.rdbG2 = new System.Windows.Forms.RadioButton();
            this.rdbG1 = new System.Windows.Forms.RadioButton();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEscolaridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltiulo
            // 
            this.lbltiulo.AutoSize = true;
            this.lbltiulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltiulo.Location = new System.Drawing.Point(198, 9);
            this.lbltiulo.Name = "lbltiulo";
            this.lbltiulo.Size = new System.Drawing.Size(107, 32);
            this.lbltiulo.TabIndex = 0;
            this.lbltiulo.Text = "Salário";
            this.lbltiulo.Click += new System.EventHandler(this.lbltiulo_Click);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFuncionario.Location = new System.Drawing.Point(32, 56);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(224, 23);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "Digite o Nome do Funcionário: ";
            this.lblFuncionario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblfinal.Location = new System.Drawing.Point(32, 141);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(155, 23);
            this.lblfinal.TabIndex = 2;
            this.lblfinal.Text = "O novo salário Será: ";
            // 
            // lblSaAtual
            // 
            this.lblSaAtual.AutoSize = true;
            this.lblSaAtual.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaAtual.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSaAtual.Location = new System.Drawing.Point(32, 100);
            this.lblSaAtual.Name = "lblSaAtual";
            this.lblSaAtual.Size = new System.Drawing.Size(171, 23);
            this.lblSaAtual.TabIndex = 3;
            this.lblSaAtual.Text = "Informe o Salário atual: ";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(262, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(185, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(262, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtFuncionário_TextChanged);
            // 
            // txtSal
            // 
            this.txtSal.BackColor = System.Drawing.Color.White;
            this.txtSal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(262, 94);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(185, 29);
            this.txtSal.TabIndex = 6;
            this.txtSal.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(55, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 79);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(204, 217);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 79);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(353, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 79);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grbEscolaridade
            // 
            this.grbEscolaridade.Controls.Add(this.rdbG3);
            this.grbEscolaridade.Controls.Add(this.rdbG2);
            this.grbEscolaridade.Controls.Add(this.rdbG1);
            this.grbEscolaridade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEscolaridade.ForeColor = System.Drawing.Color.OrangeRed;
            this.grbEscolaridade.Location = new System.Drawing.Point(502, 50);
            this.grbEscolaridade.Name = "grbEscolaridade";
            this.grbEscolaridade.Size = new System.Drawing.Size(178, 114);
            this.grbEscolaridade.TabIndex = 10;
            this.grbEscolaridade.TabStop = false;
            this.grbEscolaridade.Text = "Selecione a Escolaridade";
            this.grbEscolaridade.Enter += new System.EventHandler(this.grbEscolaridade_Enter);
            // 
            // rdbG3
            // 
            this.rdbG3.AutoSize = true;
            this.rdbG3.Location = new System.Drawing.Point(16, 75);
            this.rdbG3.Name = "rdbG3";
            this.rdbG3.Size = new System.Drawing.Size(71, 24);
            this.rdbG3.TabIndex = 2;
            this.rdbG3.TabStop = true;
            this.rdbG3.Text = "3º Grau";
            this.rdbG3.UseVisualStyleBackColor = true;
            // 
            // rdbG2
            // 
            this.rdbG2.AutoSize = true;
            this.rdbG2.Location = new System.Drawing.Point(16, 51);
            this.rdbG2.Name = "rdbG2";
            this.rdbG2.Size = new System.Drawing.Size(71, 24);
            this.rdbG2.TabIndex = 1;
            this.rdbG2.TabStop = true;
            this.rdbG2.Text = "2º Grau";
            this.rdbG2.UseVisualStyleBackColor = true;
            // 
            // rdbG1
            // 
            this.rdbG1.AutoSize = true;
            this.rdbG1.Location = new System.Drawing.Point(16, 27);
            this.rdbG1.Name = "rdbG1";
            this.rdbG1.Size = new System.Drawing.Size(71, 24);
            this.rdbG1.TabIndex = 0;
            this.rdbG1.TabStop = true;
            this.rdbG1.Text = "1º Grau";
            this.rdbG1.UseVisualStyleBackColor = true;
            this.rdbG1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Items.AddRange(new object[] {
            "Araraquara",
            "Jaboticabal",
            "Taquaritinga",
            "Guariroba",
            "Cândido Rodrigues"});
            this.cboCidade.Location = new System.Drawing.Point(502, 202);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(178, 21);
            this.cboCidade.TabIndex = 11;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(514, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecione a Cidade:";
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(710, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.grbEscolaridade);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSaAtual);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lbltiulo);
            this.Name = "frmSalario";
            this.Text = "Limpar";
            this.Load += new System.EventHandler(this.frmSalario_Load);
            this.grbEscolaridade.ResumeLayout(false);
            this.grbEscolaridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltiulo;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblSaAtual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbEscolaridade;
        private System.Windows.Forms.RadioButton rdbG3;
        private System.Windows.Forms.RadioButton rdbG2;
        private System.Windows.Forms.RadioButton rdbG1;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label label1;
    }
}

