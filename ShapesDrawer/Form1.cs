using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer
{
    public partial class Form1 : Form
    {
        private Shape shape;
        private Color color;
        List<Image> backgrounds = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            this.shape = new FreeHand(drawPanel);
            this.color = Color.Black;

            //double buffering to avoid panel flickering during drawing
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
    |       BindingFlags.Instance | BindingFlags.NonPublic, null,
            drawPanel, new object[] { true });

            backgrounds.Add(null);
            backgrounds.Add(null);
        }

        private void freeHand_Click(object sender, EventArgs e)
        {
            this.shape = new FreeHand(drawPanel);
        }

        private void line_Click(object sender, EventArgs e)
        {
            this.shape = new Line(drawPanel);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            this.shape = new Rectangle(drawPanel);
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            shape.MouseDown(e, color);
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            shape.MouseMove(e); 
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            shape.MouseUp(e);
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            shape.Paint(e); 
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            color = p.BackColor;
        }

        private void closeApp_Click(object sender, EventArgs e)
        {

        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var selectedTab = e.TabPageIndex;
            //var selectedBackground = drawPanel.BackgroundImage;
            drawPanel.BackgroundImage = backgrounds[selectedTab];
        }

        private void tabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex >= 0)
            {
                var deselectedTab = e.TabPageIndex;
                // var deselectedBackground = drawPanel.BackgroundImage;
                backgrounds[deselectedTab] = drawPanel.BackgroundImage;
            }
        }

        private void addTab_Click(object sender, EventArgs e)
        {
            backgrounds.Add(null);
            tabControl.TabPages.Add("DrawTab");
        }

        private void deleteTab_Click(object sender, EventArgs e)
        {
            var deleteTab = tabControl.SelectedIndex;
            backgrounds.RemoveAt(deleteTab);
            tabControl.TabPages.Remove(tabControl.TabPages[deleteTab]);
        }
    }
}
