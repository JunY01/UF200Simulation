using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF200Simulation
{
	public partial class BoldGroupBox : GroupBox
	{
		public BoldGroupBox()
		{
			InitializeComponent();
			base.Text = "";
		}
		private int borderWidth = 1;

		public int BorderWidth
		{
			get { return borderWidth; }
			set { borderWidth = value; this.Invalidate(); } // 当边框宽度变化时，重绘控件
		}

		//protected override void OnPaint(PaintEventArgs e)
		//{
		//	base.OnPaint(e);

		//	// 设置边框样式
		//	Pen pen = new Pen(this.ForeColor, borderWidth);
		//	pen.Alignment = PenAlignment.Inset;

		//	// 绘制边框
		//	e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);

		//	SolidBrush colorBrush = new SolidBrush(this.ForeColor);
		//	//create a brush with back color
		//	var backColor = new SolidBrush(this.BackColor);
		//	//measure the text size
		//	var size = TextRenderer.MeasureText(this.Text, this.Font);
		//	// evaluate the postiong of text from left;
		//	int left = (this.Width - size.Width) / 2;
		//	//draw a fill rectangle in order to remove the border
		//	e.Graphics.FillRectangle(backColor, new Rectangle(left, 0, size.Width, size.Height));
		//	//draw the text Now
		//	e.Graphics.DrawString(this.Text, this.Font, colorBrush, new PointF(left, 0));
		//}
		private string _text = "";

		[Browsable(true)]
		[Category("Appearance")]
		[DefaultValue("GroupBoxText")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public new string Text
		{
			get
			{

				return _text;
			}
			set
			{

				_text = value;
				this.Invalidate();
			}
		}

		/// <summary>
		/// 重绘
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			//first let the base class to draw the control 
			base.OnPaint(e);
			//create a brush with fore color
			SolidBrush colorBrush = new SolidBrush(this.ForeColor);
			//create a brush with back color
			var backColor = new SolidBrush(this.BackColor);
			//measure the text size
			var size = TextRenderer.MeasureText(this.Text, this.Font);
			// evaluate the postiong of text from left;
			int left = (this.Width - size.Width) / 2;
			//draw a fill rectangle in order to remove the border
			e.Graphics.FillRectangle(backColor, new Rectangle(left, 0, size.Width, size.Height));
			//draw the text Now
			e.Graphics.DrawString(this.Text, this.Font, colorBrush, new PointF(left, 0));
		}

	}
}
