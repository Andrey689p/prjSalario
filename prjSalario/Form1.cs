using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// <author>Andrey Bertoletti</author>
/// </summary>
namespace prjSalario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFuncionário_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSalario_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmFinal TelaFinal = new frmFinal();
            TelaFinal.ShowDialog();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSal.Text = "";
            lblResultado.Text = "";
            cboCidade.Text = "";
            rdbG1.Checked = false;
            rdbG2.Checked = false;
            rdbG3.Checked = false;
            txtName.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double salario = double.Parse(txtSal.Text);
                double newsalario = salario * 1.3;
                lblResultado.Text = "R$ " + newsalario.ToString();
                if (MessageBox.Show("Confirma o Novo Salário? ",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Salario Alterado com Sucesso!!!",
                        "Reajuste de 30%", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblResultado.Text = "";

                    MessageBox.Show("O seu Salário não tera Reajuste!!!",
                        "Salário Inalterado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (rdbG1.Checked == true)
                {
                    variaveis.varG1++;
                }
                else if (rdbG2.Checked == true)
                {
                    variaveis.varG2++;
                }
                else if(rdbG3.Checked == true)
                {
                    variaveis.varG3++;
                }
                else
                {
                    MessageBox.Show("Selecione o Grau de Escolaridade",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                txtName.Text = "";
                txtSal.Text = "";
                lblResultado.Text = "";
                cboCidade.Text = "";
                rdbG1.Checked= false;
                rdbG2.Checked = false;
                rdbG3.Checked = false;
                txtName.Focus();

            }
        }

        private void grbEscolaridade_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltiulo_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    }

