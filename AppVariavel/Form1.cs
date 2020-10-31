using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVariavel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txtMain.Text;
            MessageBox.Show(nome, "Executado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
