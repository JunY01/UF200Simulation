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
	public partial class GreenGroupBox : GroupBox
	{
		public GreenGroupBox()
		{
			InitializeComponent();
		}

		public GreenGroupBox(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			var vSize = e.Graphics.MeasureString(this.Text, this.Font);

			e.Graphics.Clear(this.BackColor);
			e.Graphics.DrawString(this.Text, this.Font, Brushes.Green, 10, 1);

			e.Graphics.DrawLine(Pens.Green, 1, vSize.Height / 2, 8, vSize.Height / 2);
			e.Graphics.DrawLine(Pens.Green, vSize.Width + 8, vSize.Height / 2, this.Width - 2, vSize.Height / 2);
			e.Graphics.DrawLine(Pens.Green, 1, vSize.Height / 2, 1, this.Height - 2);
			e.Graphics.DrawLine(Pens.Green, 1, this.Height - 2, this.Width - 2, this.Height - 2);
			e.Graphics.DrawLine(Pens.Green, this.Width - 2, vSize.Height / 2, this.Width - 2, this.Height - 2);
		}
	}
}
