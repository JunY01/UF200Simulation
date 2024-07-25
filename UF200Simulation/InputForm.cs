using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF200Simulation
{
	public partial class InputForm : Form
	{
		public InputForm()
		{
			InitializeComponent();
		}
		public string TitleText { get; set; }
		public string InputText { get; set; }
		private void InputForm_Load(object sender, EventArgs e)
		{
			lbltitle.Text = TitleText;
			textBox1.Text = InputText;
		}

		private void custButton16_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void custButton54_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.InputText = textBox1.Text;
			this.Close();
		}
	}
}
