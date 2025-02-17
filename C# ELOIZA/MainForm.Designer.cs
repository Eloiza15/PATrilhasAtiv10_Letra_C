/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 17/02/2025
 * Time: 09:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C__ELOIZA
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnExibir;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnExibir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(12, 126);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(260, 20);
			this.txtInput.TabIndex = 0;
			// 
			// btnExibir
			// 
			this.btnExibir.Location = new System.Drawing.Point(100, 69);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(75, 23);
			this.btnExibir.TabIndex = 1;
			this.btnExibir.Text = "Exibir";
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.BtnExibirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnExibir);
			this.Controls.Add(this.txtInput);
			this.Name = "MainForm";
			this.Text = "C# ELOIZA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
