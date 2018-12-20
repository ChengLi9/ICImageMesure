namespace ICImageMesure
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
            this.icImagingControl1 = new TIS.Imaging.ICImagingControl();
            this.device = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.Button();
            this.startstop = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cycle = new System.Windows.Forms.RadioButton();
            this.quadrilateral = new System.Windows.Forms.RadioButton();
            this.triangle = new System.Windows.Forms.RadioButton();
            this.segment = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.savevideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icImagingControl1
            // 
            this.icImagingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icImagingControl1.BackColor = System.Drawing.Color.White;
            this.icImagingControl1.DeviceListChangedExecutionMode = TIS.Imaging.EventExecutionMode.Invoke;
            this.icImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke;
            this.icImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded;
            this.icImagingControl1.LiveDisplayPosition = new System.Drawing.Point(0, 0);
            this.icImagingControl1.Location = new System.Drawing.Point(-2, 0);
            this.icImagingControl1.Name = "icImagingControl1";
            this.icImagingControl1.Size = new System.Drawing.Size(1031, 774);
            this.icImagingControl1.TabIndex = 0;
            this.icImagingControl1.OverlayUpdate += new System.EventHandler<TIS.Imaging.ICImagingControl.OverlayUpdateEventArgs>(this.icImagingControl1_OverlayUpdate);
            this.icImagingControl1.LivePrepared += new System.EventHandler(this.icImagingControl1_LivePrepared);
            this.icImagingControl1.DeviceLost += new System.EventHandler<TIS.Imaging.ICImagingControl.DeviceLostEventArgs>(this.icImagingControl1_DeviceLost);
            this.icImagingControl1.Load += new System.EventHandler(this.icImagingControl1_Load);
            this.icImagingControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.icImagingControl1_MouseClick);
            // 
            // device
            // 
            this.device.Location = new System.Drawing.Point(1058, 27);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(91, 25);
            this.device.TabIndex = 1;
            this.device.Text = "Device";
            this.device.UseVisualStyleBackColor = true;
            this.device.Click += new System.EventHandler(this.device_Click);
            // 
            // properties
            // 
            this.properties.Location = new System.Drawing.Point(1058, 79);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(91, 25);
            this.properties.TabIndex = 2;
            this.properties.Text = "Properties";
            this.properties.UseVisualStyleBackColor = true;
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // startstop
            // 
            this.startstop.Location = new System.Drawing.Point(1058, 130);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(91, 25);
            this.startstop.TabIndex = 3;
            this.startstop.Text = "Start Live";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(1058, 231);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(91, 25);
            this.hide.TabIndex = 4;
            this.hide.Text = "Hide the Scale";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cycle);
            this.groupBox1.Controls.Add(this.quadrilateral);
            this.groupBox1.Controls.Add(this.triangle);
            this.groupBox1.Controls.Add(this.segment);
            this.groupBox1.Location = new System.Drawing.Point(1042, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a graph ";
            // 
            // cycle
            // 
            this.cycle.AutoSize = true;
            this.cycle.Location = new System.Drawing.Point(23, 163);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(55, 17);
            this.cycle.TabIndex = 3;
            this.cycle.TabStop = true;
            this.cycle.Text = "Ellipse";
            this.cycle.UseVisualStyleBackColor = true;
            this.cycle.CheckedChanged += new System.EventHandler(this.cycle_CheckedChanged);
            // 
            // quadrilateral
            // 
            this.quadrilateral.AutoSize = true;
            this.quadrilateral.Location = new System.Drawing.Point(23, 117);
            this.quadrilateral.Name = "quadrilateral";
            this.quadrilateral.Size = new System.Drawing.Size(84, 17);
            this.quadrilateral.TabIndex = 2;
            this.quadrilateral.TabStop = true;
            this.quadrilateral.Text = "Quadrilateral";
            this.quadrilateral.UseVisualStyleBackColor = true;
            this.quadrilateral.CheckedChanged += new System.EventHandler(this.quadrilateral_CheckedChanged);
            // 
            // triangle
            // 
            this.triangle.AutoSize = true;
            this.triangle.Location = new System.Drawing.Point(23, 72);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(63, 17);
            this.triangle.TabIndex = 1;
            this.triangle.TabStop = true;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.CheckedChanged += new System.EventHandler(this.triangle_CheckedChanged);
            // 
            // segment
            // 
            this.segment.AutoSize = true;
            this.segment.Location = new System.Drawing.Point(23, 28);
            this.segment.Name = "segment";
            this.segment.Size = new System.Drawing.Size(67, 17);
            this.segment.TabIndex = 0;
            this.segment.TabStop = true;
            this.segment.Text = "Segment";
            this.segment.UseVisualStyleBackColor = true;
            this.segment.CheckedChanged += new System.EventHandler(this.segment_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(767, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(767, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(767, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDown);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(767, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            this.textBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(767, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Visible = false;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            this.textBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseDown);
            // 
            // savevideo
            // 
            this.savevideo.Location = new System.Drawing.Point(1058, 183);
            this.savevideo.Name = "savevideo";
            this.savevideo.Size = new System.Drawing.Size(91, 25);
            this.savevideo.TabIndex = 11;
            this.savevideo.Text = "Capture Video";
            this.savevideo.UseVisualStyleBackColor = true;
            this.savevideo.Click += new System.EventHandler(this.savevideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 775);
            this.Controls.Add(this.savevideo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.device);
            this.Controls.Add(this.icImagingControl1);
            this.Name = "Form1";
            this.Text = "IC Camera Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icImagingControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TIS.Imaging.ICImagingControl icImagingControl1;
        private System.Windows.Forms.Button device;
        private System.Windows.Forms.Button properties;
        private System.Windows.Forms.Button startstop;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cycle;
        private System.Windows.Forms.RadioButton quadrilateral;
        private System.Windows.Forms.RadioButton triangle;
        private System.Windows.Forms.RadioButton segment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button savevideo;
    }
}

