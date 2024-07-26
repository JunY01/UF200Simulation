using System;
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
			this.InputText = textBox1.Text;
			this.Close();
		}

		private void custButton3_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void custButton6_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void custButton7_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void custButton8_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void custButton9_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void custButton10_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}

		private void custButton12_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void custButton13_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}

		private void custButton14_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		private void custButton15_Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}

		private void custButton11_Click(object sender, EventArgs e)
		{
			textBox1.Text += "-";
		}

		private void custButton24_Click(object sender, EventArgs e)
		{
			textBox1.Text += "Q";
		}

		private void custButton23_Click(object sender, EventArgs e)
		{
			textBox1.Text += "W";
		}

		private void custButton22_Click(object sender, EventArgs e)
		{
			textBox1.Text += "E";
		}

		private void custButton21_Click(object sender, EventArgs e)
		{
			textBox1.Text += "R";
		}

		private void custButton19_Click(object sender, EventArgs e)
		{
			textBox1.Text += "Y";
		}

		private void custButton20_Click(object sender, EventArgs e)
		{
			textBox1.Text += "T";
		}

		private void custButton17_Click(object sender, EventArgs e)
		{
			textBox1.Text += "U";
		}

		private void custButton5_Click(object sender, EventArgs e)
		{
			textBox1.Text += "I";
		}

		private void custButton4_Click(object sender, EventArgs e)
		{
			textBox1.Text += "O";
		}

		private void custButton2_Click(object sender, EventArgs e)
		{
			textBox1.Text += "P";
		}

		private void custButton18_Click(object sender, EventArgs e)
		{
			textBox1.Text += @"\";
		}

		private void custButton36_Click(object sender, EventArgs e)
		{
			textBox1.Text += "A";
		}

		private void custButton35_Click(object sender, EventArgs e)
		{
			textBox1.Text += "S";
		}

		private void custButton34_Click(object sender, EventArgs e)
		{
			textBox1.Text += "D";
		}

		private void custButton33_Click(object sender, EventArgs e)
		{
			textBox1.Text += "F";
		}

		private void custButton32_Click(object sender, EventArgs e)
		{
			textBox1.Text += "G";
		}

		private void custButton31_Click(object sender, EventArgs e)
		{
			textBox1.Text += "H";
		}

		private void custButton29_Click(object sender, EventArgs e)
		{
			textBox1.Text += "J";
		}

		private void custButton28_Click(object sender, EventArgs e)
		{
			textBox1.Text += "K";
		}

		private void custButton27_Click(object sender, EventArgs e)
		{
			textBox1.Text += "L";
		}

		private void custButton26_Click(object sender, EventArgs e)
		{
			textBox1.Text += ";";
		}

		private void custButton30_Click(object sender, EventArgs e)
		{
			textBox1.Text += "=";
		}

		private void custButton25_Click(object sender, EventArgs e)
		{
			InputText = textBox1.Text;
			if (InputText.Length > 0)
			{
				textBox1.Text = InputText.Substring(0, InputText.Length - 1);
			}
		}

		private void custButton48_Click(object sender, EventArgs e)
		{
			textBox1.Text += "Z";
		}

		private void custButton47_Click(object sender, EventArgs e)
		{
			textBox1.Text += "X";
		}

		private void custButton46_Click(object sender, EventArgs e)
		{
			textBox1.Text += "C";
		}

		private void custButton45_Click(object sender, EventArgs e)
		{
			textBox1.Text += "V";
		}

		private void custButton44_Click(object sender, EventArgs e)
		{
			textBox1.Text += "B";
		}

		private void custButton43_Click(object sender, EventArgs e)
		{
			textBox1.Text += "N";
		}

		private void custButton41_Click(object sender, EventArgs e)
		{
			textBox1.Text += "M";
		}

		private void custButton40_Click(object sender, EventArgs e)
		{
			textBox1.Text += ",";
		}

		private void custButton39_Click(object sender, EventArgs e)
		{
			textBox1.Text += ".";
		}

		private void custButton38_Click(object sender, EventArgs e)
		{
			textBox1.Text += "/";
		}

		private void custButton42_Click(object sender, EventArgs e)
		{
			textBox1.Text += "+";
		}

		private void custButton51_Click(object sender, EventArgs e)
		{
			textBox1.Text += " ";
		}
	}
}
