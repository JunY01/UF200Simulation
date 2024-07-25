using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
	public partial class YellowGroupBox : GroupBox
	{
		public YellowGroupBox()
		{
			InitializeComponent();
		}

		public YellowGroupBox(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			var vSize = e.Graphics.MeasureString(this.Text, this.Font);

			e.Graphics.Clear(this.BackColor);
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(199, 151, 100)), 10, 1);
			var pen = new Pen(Color.Yellow);
			e.Graphics.DrawLine(pen, 1, vSize.Height / 2, 8, vSize.Height / 2);
			e.Graphics.DrawLine(pen, vSize.Width + 8, vSize.Height / 2, this.Width - 2, vSize.Height / 2);
			e.Graphics.DrawLine(pen, 1, vSize.Height / 2, 1, this.Height - 2);
			e.Graphics.DrawLine(pen, 1, this.Height - 2, this.Width - 2, this.Height - 2);
			e.Graphics.DrawLine(pen, this.Width - 2, vSize.Height / 2, this.Width - 2, this.Height - 2);
		}
	}
}
