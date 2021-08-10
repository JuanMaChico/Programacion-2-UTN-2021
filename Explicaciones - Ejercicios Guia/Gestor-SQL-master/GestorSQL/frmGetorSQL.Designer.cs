
namespace GestorSQL
{
    partial class frmGetorSQL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetorSQL));
            this.dgvConsultaSQL = new System.Windows.Forms.DataGridView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblSentencia = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpBoxConexion = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCandado = new System.Windows.Forms.Button();
            this.imgListCandados = new System.Windows.Forms.ImageList(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnExportar = new System.Windows.Forms.Button();
            this.rchTextSentencia = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).BeginInit();
            this.grpBoxConexion.SuspendLayout();
            this.statusStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaSQL
            // 
            this.dgvConsultaSQL.AllowUserToAddRows = false;
            this.dgvConsultaSQL.AllowUserToDeleteRows = false;
            this.dgvConsultaSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSQL.Location = new System.Drawing.Point(12, 258);
            this.dgvConsultaSQL.MultiSelect = false;
            this.dgvConsultaSQL.Name = "dgvConsultaSQL";
            this.dgvConsultaSQL.ReadOnly = true;
            this.dgvConsultaSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaSQL.Size = new System.Drawing.Size(608, 267);
            this.dgvConsultaSQL.TabIndex = 99;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.Location = new System.Drawing.Point(279, 540);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblSentencia
            // 
            this.lblSentencia.AutoSize = true;
            this.lblSentencia.Location = new System.Drawing.Point(9, 118);
            this.lblSentencia.Name = "lblSentencia";
            this.lblSentencia.Size = new System.Drawing.Size(55, 13);
            this.lblSentencia.TabIndex = 3;
            this.lblSentencia.Text = "Sentencia";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(122, 26);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(100, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // txtBaseDeDatos
            // 
            this.txtBaseDeDatos.Location = new System.Drawing.Point(228, 26);
            this.txtBaseDeDatos.Name = "txtBaseDeDatos";
            this.txtBaseDeDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBaseDeDatos.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(122, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // grpBoxConexion
            // 
            this.grpBoxConexion.Controls.Add(this.lblPassword);
            this.grpBoxConexion.Controls.Add(this.btnCandado);
            this.grpBoxConexion.Controls.Add(this.lblUsuario);
            this.grpBoxConexion.Controls.Add(this.lblBaseDeDatos);
            this.grpBoxConexion.Controls.Add(this.lblServidor);
            this.grpBoxConexion.Controls.Add(this.txtPassword);
            this.grpBoxConexion.Controls.Add(this.txtServidor);
            this.grpBoxConexion.Controls.Add(this.txtUsuario);
            this.grpBoxConexion.Controls.Add(this.txtBaseDeDatos);
            this.grpBoxConexion.Location = new System.Drawing.Point(12, 12);
            this.grpBoxConexion.Name = "grpBoxConexion";
            this.grpBoxConexion.Size = new System.Drawing.Size(342, 103);
            this.grpBoxConexion.TabIndex = 7;
            this.grpBoxConexion.TabStop = false;
            this.grpBoxConexion.Text = "Parametros de Conexion";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(236, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Constraseña:";
            // 
            // btnCandado
            // 
            this.btnCandado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCandado.FlatAppearance.BorderSize = 0;
            this.btnCandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandado.ImageIndex = 0;
            this.btnCandado.ImageList = this.imgListCandados;
            this.btnCandado.Location = new System.Drawing.Point(35, 34);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(33, 42);
            this.btnCandado.TabIndex = 4;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // imgListCandados
            // 
            this.imgListCandados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCandados.ImageStream")));
            this.imgListCandados.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCandados.Images.SetKeyName(0, "Candado.png");
            this.imgListCandados.Images.SetKeyName(1, "CandadoLock.png");
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(149, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.AutoSize = true;
            this.lblBaseDeDatos.Location = new System.Drawing.Point(236, 10);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDeDatos.TabIndex = 10;
            this.lblBaseDeDatos.Text = "Base de Datos:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(149, 10);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 9;
            this.lblServidor.Text = "Servidor:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(228, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // statusStripBar
            // 
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusText,
            this.toolProgressBar});
            this.statusStripBar.Location = new System.Drawing.Point(0, 566);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Size = new System.Drawing.Size(632, 22);
            this.statusStripBar.TabIndex = 8;
            this.statusStripBar.Text = "Estado";
            // 
            // toolStripStatusText
            // 
            this.toolStripStatusText.Name = "toolStripStatusText";
            this.toolStripStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // toolProgressBar
            // 
            this.toolProgressBar.Name = "toolProgressBar";
            this.toolProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Image = global::GestorSQL.Properties.Resources.Exportar;
            this.btnExportar.Location = new System.Drawing.Point(588, 531);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(32, 32);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // rchTextSentencia
            // 
            this.rchTextSentencia.Location = new System.Drawing.Point(12, 134);
            this.rchTextSentencia.Name = "rchTextSentencia";
            this.rchTextSentencia.Size = new System.Drawing.Size(608, 118);
            this.rchTextSentencia.TabIndex = 101;
            this.rchTextSentencia.Text = "";
            this.rchTextSentencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rchTextSentencia_KeyPress);
            // 
            // frmGetorSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 588);
            this.Controls.Add(this.rchTextSentencia);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.statusStripBar);
            this.Controls.Add(this.grpBoxConexion);
            this.Controls.Add(this.lblSentencia);
            this.Controls.Add(this.dgvConsultaSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGetorSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor SQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGetorSQL_FormClosing);
            this.Load += new System.EventHandler(this.frmGetorSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).EndInit();
            this.grpBoxConexion.ResumeLayout(false);
            this.grpBoxConexion.PerformLayout();
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaSQL;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblSentencia;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBaseDeDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpBoxConexion;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBaseDeDatos;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ImageList imgListCandados;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.StatusStrip statusStripBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusText;
        private System.Windows.Forms.ToolStripProgressBar toolProgressBar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.RichTextBox rchTextSentencia;
    }
}

