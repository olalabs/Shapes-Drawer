namespace ShapesDrawer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Button();
            this.freeHand = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.closeApp = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.saveDrawing = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.addTab = new System.Windows.Forms.Button();
            this.deleteTab = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Location = new System.Drawing.Point(137, 320);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(29, 27);
            this.panel15.TabIndex = 4;
            this.panel15.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gray;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Location = new System.Drawing.Point(86, 320);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(29, 27);
            this.panel14.TabIndex = 19;
            this.panel14.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Location = new System.Drawing.Point(37, 320);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(29, 27);
            this.panel13.TabIndex = 5;
            this.panel13.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Purple;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Location = new System.Drawing.Point(137, 274);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(29, 27);
            this.panel12.TabIndex = 6;
            this.panel12.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Pink;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Location = new System.Drawing.Point(86, 274);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(29, 27);
            this.panel11.TabIndex = 7;
            this.panel11.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Orange;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Location = new System.Drawing.Point(37, 276);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(29, 25);
            this.panel10.TabIndex = 8;
            this.panel10.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(137, 227);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(29, 25);
            this.panel9.TabIndex = 9;
            this.panel9.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(86, 227);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(29, 25);
            this.panel8.TabIndex = 10;
            this.panel8.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(37, 227);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(29, 25);
            this.panel7.TabIndex = 11;
            this.panel7.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(137, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 25);
            this.panel6.TabIndex = 12;
            this.panel6.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(86, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 25);
            this.panel5.TabIndex = 13;
            this.panel5.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(37, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 25);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-2, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 25);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // line
            // 
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(74, 93);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(59, 51);
            this.line.TabIndex = 17;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // freeHand
            // 
            this.freeHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("freeHand.BackgroundImage")));
            this.freeHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.freeHand.FlatAppearance.BorderSize = 0;
            this.freeHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeHand.Location = new System.Drawing.Point(9, 93);
            this.freeHand.Name = "freeHand";
            this.freeHand.Size = new System.Drawing.Size(59, 51);
            this.freeHand.TabIndex = 15;
            this.freeHand.UseVisualStyleBackColor = true;
            this.freeHand.Click += new System.EventHandler(this.freeHand_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Location = new System.Drawing.Point(139, 93);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(59, 51);
            this.rectangle.TabIndex = 16;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(224, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(625, 42);
            this.tabControl.TabIndex = 20;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            this.tabControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Deselecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 16);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DrawTab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(622, 24);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DrawTab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawPanel.Location = new System.Drawing.Point(224, 82);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(625, 379);
            this.drawPanel.TabIndex = 21;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // closeApp
            // 
            this.closeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeApp.BackgroundImage")));
            this.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeApp.FlatAppearance.BorderSize = 0;
            this.closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApp.Location = new System.Drawing.Point(812, 2);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(51, 42);
            this.closeApp.TabIndex = 22;
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize.BackgroundImage")));
            this.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Location = new System.Drawing.Point(753, 2);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(53, 42);
            this.maximize.TabIndex = 23;
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(692, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(55, 42);
            this.minimize.TabIndex = 24;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // saveDrawing
            // 
            this.saveDrawing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveDrawing.BackgroundImage")));
            this.saveDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveDrawing.FlatAppearance.BorderSize = 0;
            this.saveDrawing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDrawing.Location = new System.Drawing.Point(12, 379);
            this.saveDrawing.Name = "saveDrawing";
            this.saveDrawing.Size = new System.Drawing.Size(78, 45);
            this.saveDrawing.TabIndex = 25;
            this.saveDrawing.UseVisualStyleBackColor = true;
            // 
            // loadFromFile
            // 
            this.loadFromFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadFromFile.BackgroundImage")));
            this.loadFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadFromFile.FlatAppearance.BorderSize = 0;
            this.loadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromFile.Location = new System.Drawing.Point(102, 379);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(64, 45);
            this.loadFromFile.TabIndex = 26;
            this.loadFromFile.UseVisualStyleBackColor = true;
            // 
            // addTab
            // 
            this.addTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTab.BackgroundImage")));
            this.addTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addTab.FlatAppearance.BorderSize = 0;
            this.addTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTab.Location = new System.Drawing.Point(37, 12);
            this.addTab.Name = "addTab";
            this.addTab.Size = new System.Drawing.Size(42, 49);
            this.addTab.TabIndex = 27;
            this.addTab.UseVisualStyleBackColor = true;
            this.addTab.Click += new System.EventHandler(this.addTab_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteTab.BackgroundImage")));
            this.deleteTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteTab.FlatAppearance.BorderSize = 0;
            this.deleteTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTab.Location = new System.Drawing.Point(116, 12);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Size = new System.Drawing.Size(41, 49);
            this.deleteTab.TabIndex = 28;
            this.deleteTab.UseVisualStyleBackColor = true;
            this.deleteTab.Click += new System.EventHandler(this.deleteTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 470);
            this.Controls.Add(this.deleteTab);
            this.Controls.Add(this.addTab);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.saveDrawing);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.line);
            this.Controls.Add(this.freeHand);
            this.Controls.Add(this.rectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Shape Drawer";
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button freeHand;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button saveDrawing;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.Button addTab;
        private System.Windows.Forms.Button deleteTab;
    }
}

