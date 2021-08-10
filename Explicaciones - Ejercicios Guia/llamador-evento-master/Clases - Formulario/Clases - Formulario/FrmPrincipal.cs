using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clases___Formulario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.grbBotones.Controls)
            {
                item.Click += AsignarBoton;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void AsignarBoton(object sender, EventArgs e)
        {
            this.txtNumeros.Text += ((Control)(sender)).Text;
        }
        private void Limpiar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

    }
}
