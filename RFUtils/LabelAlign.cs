using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFClicker
{
    class LabelAlign : Label
    {
        private TextFormatFlags flags = TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;

        public bool RightAlignment
        {
            get
            {
                return (flags & TextFormatFlags.Right) == TextFormatFlags.Right;
            }
            set
            {
                if (value)
                {
                    flags = flags |= TextFormatFlags.Right;
                }
                else
                {
                    flags = flags &= ~TextFormatFlags.Right;
                }
                Invalidate();
            }
        }


        public void NoPaddingLabel()
        {
            //InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, ClientRectangle, this.ForeColor, Color.Transparent, flags);
        }

    }
}
