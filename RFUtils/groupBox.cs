using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisingForceUtils
{
    public partial class Form1 : Form
    {

        private Color _borderColor = Color.FromArgb(255, 50, 50, 50);
        private Color _textColor = Color.FromArgb(255, 120, 120, 120);
        

        private void PaintCustomGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;

            Size labelSize = TextRenderer.MeasureText(box.Text, box.Font);

            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y = (borderRect.Y + (labelSize.Height / 2));
            borderRect.Height = (borderRect.Height - (labelSize.Height / 2));
            ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = e.ClipRectangle;
            textRect.X = (textRect.X + 6);
            textRect.Width = labelSize.Width;
            textRect.Height = labelSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(box.Text, box.Font, new SolidBrush(this._textColor), textRect);
        }

    }
}
