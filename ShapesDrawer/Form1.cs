using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
        //moving the window 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        //rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.shape = new FreeHand(drawPanel);
            this.color = Color.Black;

            //double buffering to avoid panel flickering during drawing
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            drawPanel, new object[] { true });

            //rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
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
            System.Windows.Forms.Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex >= 0)
            {
                var selectedTab = e.TabPageIndex;
                drawPanel.BackgroundImage = backgrounds[selectedTab];
            }
        }

        private void tabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex >= 0)
            {
                var deselectedTab = e.TabPageIndex;
                backgrounds[deselectedTab] = drawPanel.BackgroundImage;
            }
        }

        private void addTab_Click(object sender, EventArgs e)
        {
            backgrounds.Add(null);
            tabControl.TabPages.Add("DrawTab");

            tabControl.SelectedIndex = tabControl.TabCount - 1;
        }

        private void deleteTab_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex >= 0)
            {
                var deleteTab = tabControl.SelectedIndex;
                backgrounds.RemoveAt(deleteTab);
                tabControl.TabPages.Remove(tabControl.TabPages[deleteTab]);
            }
            if(tabControl.SelectedIndex == -1)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void saveDrawing_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(drawPanel.Width, drawPanel.Height - 50, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics Grap = Graphics.FromImage(bmp);

            Grap.CopyFromScreen(PointToScreen(drawPanel.Location).X, PointToScreen(drawPanel.Location).Y, 0, 0, drawPanel.Size, CopyPixelOperation.SourceCopy);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.bmp; *.jpg; *.jpeg,*.png)| *.BMP; *.JPG; *.JPEG; *.PNG";
            DialogResult dialogResult = save.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bmp.Save(save.FileName);
                MessageBox.Show("The picture has been saved!");
            }
        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "(*.bmp; *.jpg; *.jpeg,*.png)| *.BMP; *.JPG; *.JPEG; *.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    drawPanel.BackgroundImage = Image.FromFile(dlg.FileName);
                }
            }
        }

        //moving the window
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle,
                WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.drawPanel.BackgroundImage = null;
        }
    }
}
