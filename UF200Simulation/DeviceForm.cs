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
	public partial class DeviceForm : Form
	{
		public DeviceForm()
		{
			InitializeComponent();
			treeView1.ExpandAll();
		}

		private void label10_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.TitleText = "Device";
			var str = label10.Text.Split(':');
			inputForm.InputText= str[1].Trim();
			inputForm.StartPosition = FormStartPosition.CenterParent;
			inputForm.ShowDialog(this);
			string DataToPass = inputForm.InputText;
			label10.Text = str[0] + ":" + DataToPass;
		}
	}
}
