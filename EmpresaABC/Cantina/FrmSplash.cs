using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void lblPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {

            if (pgbSplash.Maximum < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 1;
                lblValor.Text = pgbSplash.Value.ToString();

            }
            else
                FrmLogin1 abrir = new FrmLogin1();
            abrir.Show();
            this.Hide();
            tmrSplash.
        }
    }
