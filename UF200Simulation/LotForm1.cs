using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF200Simulation
{
	public partial class LotForm1 : Form
	{
		public LotForm1()
		{
			InitializeComponent();
		}
		public string DeviceText { get; set; } = "SPQ2R4N-4SGA-2K";
		private void custButton12_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.TitleText = "Lot #";
			var str = custButton12.Text.Split(' ');
			inputForm.InputText = str[str.Length - 1].Trim();
			inputForm.StartPosition = FormStartPosition.CenterParent;
			inputForm.ShowDialog(this);
			var lotText = inputForm.InputText;
			custButton12.Text = "Lot #\r\n\r\n  " + lotText;
		}

		private void custButton13_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.TitleText = "Operator Name";
			var str = custButton13.Text.Split(' ');
			inputForm.InputText = str[str.Length - 1].Trim();
			inputForm.StartPosition = FormStartPosition.CenterParent;
			inputForm.ShowDialog(this);
			var operText = inputForm.InputText;
			custButton13.Text = "Operator Name\r\n\r\n  " + operText;
		}

		private void LotForm1_Load(object sender, EventArgs e)
		{
			custButton14.Text= "Device\r\n\r\n  " + DeviceText;
		}

		private void custButton9_Click(object sender, EventArgs e)
		{
			LotForm2 lotForm2 = new LotForm2();
			lotForm2.DeviceText= DeviceText;
			lotForm2.StartPosition = FormStartPosition.CenterParent;
			lotForm2.ShowDialog(this);
			this.Close();
		}
	}
}
