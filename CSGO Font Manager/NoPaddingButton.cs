using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Font_Manager
{
    public class NoPaddingButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //omit base.OnPaint completely...

            //base.OnPaint(pevent); 

            using (Pen p = new Pen(BackColor))
            {
                pevent.Graphics.FillRectangle(p.Brush, ClientRectangle);
            }

            //add code here to draw borders...

            using (Pen p = new Pen(ForeColor))
            {
                pevent.Graphics.DrawString(this.Text, Font, p.Brush, new PointF(this.Width / 2 - pevent.Graphics.MeasureString(this.Text, Font, int.MaxValue).Width / 2, this.Height / 2 - pevent.Graphics.MeasureString(this.Text, Font, int.MaxValue).Height / 2));
            }
        }
    }
}
