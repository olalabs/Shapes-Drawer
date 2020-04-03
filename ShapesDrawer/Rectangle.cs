using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer
{
    class Rectangle : Shape
    {
        public Rectangle(Panel drawPanel) : base(drawPanel)
        {
           
        }  

        public override void MouseMove(MouseEventArgs mouseEventArg)
        {
            if (GetClick() == true)
            {
                SetEndpoint(mouseEventArg.Location); 
                GetDrawpanel().Refresh(); 
            }
        }

        public override void Paint(PaintEventArgs paintEventArg)
        {
            var startpoint = GetStartpoint();
            var endPoint = GetEndpoint(); 

            System.Drawing.Rectangle drawRectangle = new System.Drawing.Rectangle();
            drawRectangle.X = Math.Min(startpoint.X, endPoint.X);
            drawRectangle.Y = Math.Min(startpoint.Y, endPoint.Y);

            drawRectangle.Width = Math.Abs(startpoint.X - endPoint.X);
            drawRectangle.Height = Math.Abs(startpoint.Y - endPoint.Y);

            paintEventArg.Graphics.DrawRectangle(new Pen(GetColor(), 5), drawRectangle);
        }

        public override void SelectColor(PaintEventArgs paintEventArgs)
        {

        }
    }
}
