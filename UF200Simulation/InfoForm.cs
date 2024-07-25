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
	public partial class InfoForm : Form
	{
		public InfoForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Form1 childForm = new Form1();
			//childForm.StartPosition = FormStartPosition.CenterParent;
			//childForm.Show();
		}

		private void InfoForm_Load(object sender, EventArgs e)
		{

		}

		private void custButton3_Click(object sender, EventArgs e)
		{
			//InputForm inputForm = new InputForm();
			//inputForm.TitleText = "Device";

			//inputForm.StartPosition = FormStartPosition.CenterParent;

			//inputForm.ShowDialog(this);
			DeviceForm deviceForm = new DeviceForm();
			deviceForm.StartPosition = FormStartPosition.CenterParent;

			deviceForm.ShowDialog(this);
		}
	}
}
