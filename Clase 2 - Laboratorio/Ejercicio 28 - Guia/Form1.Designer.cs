
namespace Ejercicio_28___Guia
{
	partial class FormPrincipal
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
			this.TextBox = new System.Windows.Forms.RichTextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBox
			// 
			this.TextBox.Location = new System.Drawing.Point(12, 12);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(776, 394);
			this.TextBox.TabIndex = 0;
			this.TextBox.Text = "";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Location = new System.Drawing.Point(326, 415);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(133, 23);
			this.BtnCalcular.TabIndex = 1;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.TextBox);
			this.Name = "FormPrincipal";
			this.Text = "Contador De Palabras";
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox TextBox;
		private System.Windows.Forms.Button BtnCalcular;
	}
}

