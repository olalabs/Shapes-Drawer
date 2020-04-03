using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer
{
    class FreeHand : Shape
    {
        private List<Point> points;
 
        public FreeHand(Panel drawPanel):base(drawPanel) 
        {
            points = new List<Point>();
        }

        public override void MouseMove(MouseEventArgs mouseEventArg)
        {
            if (GetClick() == true)
            {
                //drawing preview - location assigned in real time during mouse movement
                SetEndpoint(mouseEventArg.Location);
                GetDrawpanel().Refresh();

                points.Add(mouseEventArg.Location); 
            }
            else
            {
                //new move from a different point than the end of the previous one
                //the color is not overwritten
                points.Clear(); 
            }
        }
        
        public override void Paint(PaintEventArgs paintEventArg)
        {
            if(points.Any() && points.Count >= 2)
            {
                paintEventArg.Graphics.DrawLines(new Pen(GetColor(), 5), points.ToArray());
            }
        }

        public override void SelectColor(PaintEventArgs paintEventArgs)
        {
           
        }
    }
}
