using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;


namespace GestorSQL
{
    public partial class frmGetorSQL : Form
    {
        Actualizador callbackActualizador;
        Informador callbackInformador;
        private List<string> palabrasClaves;
        private GestorDataBase gestor;
        private bool flagEvento;
        private int ultimaPos;
        public frmGetorSQL()
        {
            InitializeComponent();
        }

        private void frmGetorSQL_Load(object sender, EventArgs e)
        {
            this.palabrasClaves = new List<string> { "SELECT", "IN", "FROM", "GROUP BY", "AS", "SUM", "AND", "WHERE", "OR", "ORDER BY", "ASC", "DESC", "INNER JOIN", "ON", "LIKE", "=", "!="};
            this.toolProgressBar.Visible = false;
            this.flagEvento = false;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnCandado.ImageIndex != 0)
                {
                    this.gestor.Sentencia = this.rchTextSentencia.Text;
                    this.gestor.Activar = true;
                    this.toolStripStatusText.Text = "Consultando";
                    this.toolProgressBar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Debe establecer la conexion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            bool flagAux;
            if (this.btnCandado.ImageIndex == 0)
            {
                gestor = new GestorDataBase(this.txtServidor.Text, this.txtBaseDeDatos.Text, this.txtUsuario.Text, this.txtPassword.Text);

                this.gestor.EventoActualizarBaseDedatos += this.ObtenerDatosBD;
                this.gestor.EventoInformarBaseDeDatos += this.MensajeDeEvento;
                this.btnCandado.ImageIndex = 1;
                flagAux = false;
            }
            else
            {
                this.btnCandado.ImageIndex = 0;
                flagAux = true;
            }
            this.Bloqueo(flagAux);
        }

        /// <summary>
        /// Metodo privado que recibe un bool y modifica la vibilidad de los controles al seleccionar el candado
        /// </summary>
        /// <param name="flag">Es el valor a establecer</param>
        private void Bloqueo(bool flag)
        {
            this.txtServidor.Enabled = flag;
            this.txtBaseDeDatos.Enabled = flag;
            this.txtUsuario.Enabled = flag;
            this.txtPassword.Enabled = flag;
     
        }

        private void frmGetorSQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!object.ReferenceEquals(this.gestor, null) && this.gestor.Activar == true)
            {
                this.gestor.Activar = false;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(Exportar);
            if (!this.flagEvento)
            {
                Excel.EventoInformarExportacion += this.MensajeDeEvento;
                this.flagEvento = true;
            }
            this.toolProgressBar.Visible = true;
            this.toolStripStatusText.Text = "Exportando";
            hilo.Start();
        }
        /// <summary>
        /// Metodo que va a manajear el evento de mostrar un mensaje producido en el hilo secundario
        /// </summary>
        /// <param name="mensaje">Es el mensaje que se va a mostrar</param>
        public void MensajeDeEvento(string mensaje)
        {
            if (this.statusStripBar.InvokeRequired)
            {
                callbackInformador = new Informador(this.MensajeDeEvento);
                object[] objs = new object[] { mensaje };
                this.Invoke(callbackInformador, objs);
            }
            else
            {
                MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.toolProgressBar.Visible = false;
                this.toolStripStatusText.Text = "Finalizado";
            }
        }
        /// <summary>
        /// Metodo que va a manejar el evento de obtener datos desde el SQL
        /// </summary>
        /// <param name="datos">Son los datos que se van a asignar en el DataGrid</param>
        private void ObtenerDatosBD(DataTable datos)
        {
            if (this.dgvConsultaSQL.InvokeRequired)
            {
                callbackActualizador = new Actualizador(this.ObtenerDatosBD);
                object[] objs = new object[] { datos };
                this.Invoke(callbackActualizador, objs);
            }
            else
            {
                this.dgvConsultaSQL.DataSource = datos;
                this.toolProgressBar.Visible = false;
                this.toolStripStatusText.Text = "Finalizado";
            }
        }
        private void Exportar()
        {
            Excel.ExportarExcel(this.dgvConsultaSQL);
        }

        private void ModificarPalabrasClaves()
        {
            int index = 0;
            this.ultimaPos= this.rchTextSentencia.SelectionStart;

            foreach (string item in this.palabrasClaves)
            {
                index = 0;
                int ultimaAparicion = this.rchTextSentencia.Text.LastIndexOf(item);
                while (index <= ultimaAparicion)
                {
                    this.rchTextSentencia.Find(item, index, this.rchTextSentencia.Text.Length, RichTextBoxFinds.WholeWord);
                    this.rchTextSentencia.SelectionColor = Color.Red;
                    this.rchTextSentencia.SelectionFont = new Font(this.rchTextSentencia.Font, FontStyle.Bold);
                    index = this.rchTextSentencia.Text.IndexOf(item, index) + 1;
                }
            }
            this.rchTextSentencia.Select(this.ultimaPos,0);
            this.rchTextSentencia.SelectionColor = this.rchTextSentencia.ForeColor;
            this.rchTextSentencia.SelectionFont = new Font(this.rchTextSentencia.Font, FontStyle.Regular);
        }

        private void rchTextSentencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ultimaPos = this.rchTextSentencia.SelectionStart;
            this.ModificarPalabrasClaves();
        }
    }
}
