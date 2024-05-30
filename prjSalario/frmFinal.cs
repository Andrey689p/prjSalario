using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalario
{
    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void frmFinal_Load(object sender, EventArgs e)
        {
            lblG1.Text = Convert.ToString(variaveis.varG1);
            lblG2.Text = Convert.ToString(variaveis.varG2);
            lblG3.Text = Convert.ToString(variaveis.varG3);
        }
    }
}
