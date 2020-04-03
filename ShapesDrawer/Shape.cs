using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer
{
    abstract class Shape
    {
        private Panel drawPanel;
        private bool click = false;
        private Color color;
        private Point startpoint;
        private Point endPoint;

        public Shape(Panel drawPanel)
        {
            this.drawPanel = drawPanel;
        }

        public Panel GetDrawpanel()
        {
            return drawPanel; 
        }

        public bool GetClick()
        {
            return click; 
        }

        public Point GetStartpoint()
        {
            return startpoint; 
        }

        public void SetEndpoint(Point endPoint)
        {
            this.endPoint = endPoint; 
        }

        public Point GetEndpoint()
        {
            return endPoint; 
        }

        public Color GetColor()
        {
            return color; 
        }

        public void MouseDown(MouseEventArgs mouseEventArg, Color color)
        {
            click = true;
            startpoint = mouseEventArg.Location;
            this.color = color;
        }

        public void MouseUp(MouseEventArgs mouseEventArg)
        {
            click = false;
            endPoint = mouseEventArg.Location;

            Bitmap bitmap = new Bitmap(drawPanel.Width, drawPanel.Height); 
            drawPanel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, drawPanel.Width, drawPanel.Height)); // get panel content and throw it into the bitmap 
            drawPanel.BackgroundImage = bitmap; // set the drawing as a panel background
        }

        public abstract void MouseMove(MouseEventArgs mouseEventArg);

        public abstract void Paint(PaintEventArgs paintEventArgs); 

        public abstract void SelectColor(PaintEventArgs paintEventArgs); 
    }
}
