using System;
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
		public string DeviceText { get; set; } = "SPQ2R4N-4SGA-2K";
		private void label10_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.TitleText = "Device";
			var str = label10.Text.Split(':');
			inputForm.InputText= str[1].Trim();
			inputForm.StartPosition = FormStartPosition.CenterParent;
			inputForm.ShowDialog(this);
			DeviceText = inputForm.InputText;
			label10.Text = str[0] + ":" + DeviceText;
		}

		private void custButton6_Click(object sender, EventArgs e)
		{
			UpdateForm updateForm = new UpdateForm();
			updateForm.StartPosition = FormStartPosition.CenterParent;
			Timer timer = new Timer();
			timer.Interval = 2000;
			timer.Tick += (s, args) =>
			{
				updateForm.Close();
				timer.Stop();
			};
			timer.Start();
			updateForm.ShowDialog(this);
			this.Close();
		}
	}
}
