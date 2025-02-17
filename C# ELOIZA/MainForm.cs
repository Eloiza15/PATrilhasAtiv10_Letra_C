//Crie um formulário com uma caixa de texto e um botão. Ao clicar no botão,
//exiba um MessageBox com o texto digitado na caixa de texto.
	
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C__ELOIZA
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnExibirClick(object sender, EventArgs e)
		{
			string textoDigitado = txtInput.Text;
			
			MessageBox.Show(textoDigitado, "Eloiza programando em C#");
		}
		
	}
}
