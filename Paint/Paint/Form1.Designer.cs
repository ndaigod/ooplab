namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.ATrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CurColorPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorPickerPictureBox = new System.Windows.Forms.PictureBox();
            this.LineButton = new System.Windows.Forms.ToolStripButton();
            this.CircleButton = new System.Windows.Forms.ToolStripButton();
            this.ElipseButton = new System.Windows.Forms.ToolStripButton();
            this.SquareButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.TriangleButton = new System.Windows.Forms.ToolStripButton();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineButton,
            this.CircleButton,
            this.ElipseButton,
            this.SquareButton,
            this.RectangleButton,
            this.TriangleButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(47, 676);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(889, 235);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(25, 20);
            this.RLabel.TabIndex = 4;
            this.RLabel.Text = "R:";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Location = new System.Drawing.Point(889, 288);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(26, 20);
            this.GLabel.TabIndex = 5;
            this.GLabel.Text = "G:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(889, 341);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(24, 20);
            this.BLabel.TabIndex = 6;
            this.BLabel.Text = "B:";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(889, 395);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(24, 20);
            this.ALabel.TabIndex = 7;
            this.ALabel.Text = "A:";
            // 
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(963, 235);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Size = new System.Drawing.Size(242, 69);
            this.RTrackBar.TabIndex = 8;
            // 
            // GTrackBar
            // 
            this.GTrackBar.Location = new System.Drawing.Point(963, 288);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Size = new System.Drawing.Size(242, 69);
            this.GTrackBar.TabIndex = 9;
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(963, 341);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Size = new System.Drawing.Size(242, 69);
            this.BTrackBar.TabIndex = 10;
            // 
            // ATrackBar
            // 
            this.ATrackBar.Location = new System.Drawing.Point(963, 395);
            this.ATrackBar.Maximum = 255;
            this.ATrackBar.Name = "ATrackBar";
            this.ATrackBar.Size = new System.Drawing.Size(242, 69);
            this.ATrackBar.TabIndex = 11;
            // 
            // CurColorPictureBox
            // 
            this.CurColorPictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.CurColorPictureBox.Location = new System.Drawing.Point(889, 78);
            this.CurColorPictureBox.Name = "CurColorPictureBox";
            this.CurColorPictureBox.Size = new System.Drawing.Size(113, 115);
            this.CurColorPictureBox.TabIndex = 3;
            this.CurColorPictureBox.TabStop = false;
            // 
            // ColorPickerPictureBox
            // 
            this.ColorPickerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPickerPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ColorPickerPictureBox.Image = global::Paint.Properties.Resources.colorpicker1;
            this.ColorPickerPictureBox.Location = new System.Drawing.Point(1022, 12);
            this.ColorPickerPictureBox.Name = "ColorPickerPictureBox";
            this.ColorPickerPictureBox.Size = new System.Drawing.Size(183, 183);
            this.ColorPickerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorPickerPictureBox.TabIndex = 2;
            this.ColorPickerPictureBox.TabStop = false;
            this.ColorPickerPictureBox.Click += new System.EventHandler(this.ColorPickerPictureBox_Click);
            // 
            // LineButton
            // 
            this.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineButton.Image = global::Paint.Properties.Resources.line;
            this.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(44, 34);
            this.LineButton.Text = "Line";
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleButton.Image = global::Paint.Properties.Resources.circle;
            this.CircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(44, 34);
            this.CircleButton.Text = "Circle";
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // ElipseButton
            // 
            this.ElipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ElipseButton.Image = global::Paint.Properties.Resources.elipse;
            this.ElipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(44, 34);
            this.ElipseButton.Text = "Elipse";
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SquareButton.Image = global::Paint.Properties.Resources.square;
            this.SquareButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(44, 34);
            this.SquareButton.Text = "Square";
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = global::Paint.Properties.Resources.rectangle;
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(44, 34);
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TriangleButton.Image = global::Paint.Properties.Resources.triangle;
            this.TriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(44, 34);
            this.TriangleButton.Text = "Triangle";
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPictureBox.Image = global::Paint.Properties.Resources.back1;
            this.MainPictureBox.Location = new System.Drawing.Point(55, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(808, 592);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.MainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1217, 676);
            this.Controls.Add(this.ATrackBar);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.CurColorPictureBox);
            this.Controls.Add(this.ColorPickerPictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LineButton;
        private System.Windows.Forms.ToolStripButton CircleButton;
        private System.Windows.Forms.ToolStripButton ElipseButton;
        private System.Windows.Forms.ToolStripButton SquareButton;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton TriangleButton;
        private System.Windows.Forms.PictureBox ColorPickerPictureBox;
        private System.Windows.Forms.PictureBox CurColorPictureBox;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.TrackBar ATrackBar;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

