using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
	public partial class CustButton : Button
	{
		public CustButton()
		{
			InitializeComponent();
		}

		public CustButton(IContainer container)
		{
			container.Add(this);

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
