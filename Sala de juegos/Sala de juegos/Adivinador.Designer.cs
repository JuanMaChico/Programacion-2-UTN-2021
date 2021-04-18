
namespace Sala_de_juegos
{
	partial class Adivinador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adivinador));
			this.button1 = new System.Windows.Forms.Button();
			this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RdBtn_Lvl3 = new System.Windows.Forms.RadioButton();
			this.RdBtn_Lvl2 = new System.Windows.Forms.RadioButton();
			this.RdBtn_Lvl1 = new System.Windows.Forms.RadioButton();
			this.txtNameJugador = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Adivinar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtNumeroIngresado
			// 
			this.txtNumeroIngresado.Location = new System.Drawing.Point(128, 135);
			this.txtNumeroIngresado.Name = "txtNumeroIngresado";
			this.txtNumeroIngresado.Size = new System.Drawing.Size(99, 20);
			this.txtNumeroIngresado.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ingrese Numero: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RdBtn_Lvl3);
			this.groupBox1.Controls.Add(this.RdBtn_Lvl2);
			this.groupBox1.Controls.Add(this.RdBtn_Lvl1);
			this.groupBox1.Location = new System.Drawing.Point(12, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 66);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rangos";
			// 
			// RdBtn_Lvl3
			// 
			this.RdBtn_Lvl3.AutoSize = true;
			this.RdBtn_Lvl3.Location = new System.Drawing.Point(180, 28);
			this.RdBtn_Lvl3.Name = "RdBtn_Lvl3";
			this.RdBtn_Lvl3.Size = new System.Drawing.Size(61, 17);
			this.RdBtn_Lvl3.TabIndex = 6;
			this.RdBtn_Lvl3.Text = "Experto";
			this.RdBtn_Lvl3.UseVisualStyleBackColor = true;
			// 
			// RdBtn_Lvl2
			// 
			this.RdBtn_Lvl2.AutoSize = true;
			this.RdBtn_Lvl2.Location = new System.Drawing.Point(89, 28);
			this.RdBtn_Lvl2.Name = "RdBtn_Lvl2";
			this.RdBtn_Lvl2.Size = new System.Drawing.Size(74, 17);
			this.RdBtn_Lvl2.TabIndex = 5;
			this.RdBtn_Lvl2.Text = "Intermedio";
			this.RdBtn_Lvl2.UseVisualStyleBackColor = true;
			// 
			// RdBtn_Lvl1
			// 
			this.RdBtn_Lvl1.AutoSize = true;
			this.RdBtn_Lvl1.Checked = true;
			this.RdBtn_Lvl1.Location = new System.Drawing.Point(6, 28);
			this.RdBtn_Lvl1.Name = "RdBtn_Lvl1";
			this.RdBtn_Lvl1.Size = new System.Drawing.Size(47, 17);
			this.RdBtn_Lvl1.TabIndex = 4;
			this.RdBtn_Lvl1.TabStop = true;
			this.RdBtn_Lvl1.Text = "Facil";
			this.RdBtn_Lvl1.UseVisualStyleBackColor = true;
			// 
			// txtNameJugador
			// 
			this.txtNameJugador.AutoSize = true;
			this.txtNameJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNameJugador.Location = new System.Drawing.Point(98, 9);
			this.txtNameJugador.Name = "txtNameJugador";
			this.txtNameJugador.Size = new System.Drawing.Size(0, 16);
			this.txtNameJugador.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Jugador : ";
			// 
			// Adivinador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 212);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNameJugador);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNumeroIngresado);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Adivinador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adivinador";
			this.Load += new System.EventHandler(this.Adivinador_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtNumeroIngresado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label txtNameJugador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton RdBtn_Lvl3;
		private System.Windows.Forms.RadioButton RdBtn_Lvl2;
		private System.Windows.Forms.RadioButton RdBtn_Lvl1;
	}
}