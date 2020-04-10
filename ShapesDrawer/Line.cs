using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer
{
    class Line : Shape
    {
        public Line(Panel drawPanel) : base(drawPanel) 
        {

        }

        public override void MouseMove(MouseEventArgs mouseEventArg)
        {
            if (GetClick() == true)
            {
                SetEndpoint(mouseEventArg.Location); 
                GetDrawpanel().Refresh();
            }
            else
            {
                SetEndpoint(new Point(0, 0));
                SetStartpoint(new Point(0, 0));
            }
        }

        public override void Paint(PaintEventArgs paintEventArg)
        {
            paintEventArg.Graphics.DrawLine(new Pen(GetColor(), 5), GetStartpoint(), GetEndpoint());
        }

        public override void SelectColor(PaintEventArgs paintEventArgs)
        {
            // PictureBox p = (PictureBox)paintEventArgs;
        }
    }
}
