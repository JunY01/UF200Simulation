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
	public partial class BoldButton : Button
	{
		public BoldButton()
		{
			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
				this.BackColor, 5, ButtonBorderStyle.Outset,
				this.BackColor, 5, ButtonBorderStyle.Outset,
				this.BackColor, 5, ButtonBorderStyle.Outset,
				this.BackColor, 5, ButtonBorderStyle.Outset);
		}
	}
}
