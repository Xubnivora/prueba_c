using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }




        private void toolmenuArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos FrmArticulos = new FormArticulos();
            FrmArticulos.Show();




        }

        private void toolmenuEncKardex_Click(object sender, EventArgs e)
        {
            FormEncCardex Frmkradex = new FormEncCardex();
            Frmkradex.Show();
        }

        private void toolmenuDetKardex_Click(object sender, EventArgs e)
        {
            Frmdetalle Frmdetalle= new Frmdetalle();
            Frmdetalle.Show();
        }
    }
}
