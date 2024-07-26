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


		private void InfoForm_Load(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
		}

		private void custButton2_Click(object sender, EventArgs e)
		{
			DeviceForm deviceForm = new DeviceForm();
			deviceForm.StartPosition = FormStartPosition.CenterParent;
			deviceForm.ShowDialog(this);
			lblDevice.Text= deviceForm.DeviceText;
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void custButton1_Click(object sender, EventArgs e)
		{
			LotForm1 lotForm1 = new LotForm1();
			lotForm1.StartPosition = FormStartPosition.CenterParent;
			lotForm1.DeviceText = lblDevice.Text;
			lotForm1.ShowDialog(this);
		}
	}
}
