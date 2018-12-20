namespace ICImageMesure
{
    partial class SaveVideoForm
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
            this.chkPause = new System.Windows.Forms.CheckBox();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.MaskedTextBox();
            this.cboVideoCodec = new System.Windows.Forms.ComboBox();
            this.cboMediaStreamContainer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkPause
            // 
            this.chkPause.AutoSize = true;
            this.chkPause.Location = new System.Drawing.Point(152, 129);
            this.chkPause.Name = "chkPause";
            this.chkPause.Size = new System.Drawing.Size(56, 17);
            this.chkPause.TabIndex = 23;
            this.chkPause.Text = "Pause";
            this.chkPause.UseVisualStyleBackColor = true;
            this.chkPause.CheckedChanged += new System.EventHandler(this.chkPause_CheckedChanged);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(51, 125);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(81, 23);
            this.btnStartCapture.TabIndex = 22;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Location = new System.Drawing.Point(249, 125);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(89, 23);
            this.btnStopCapture.TabIndex = 21;
            this.btnStopCapture.Text = "Stop Capture";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(346, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(346, 78);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(346, 45);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(75, 23);
            this.btnProperties.TabIndex = 18;
            this.btnProperties.Text = "Properties...";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(138, 81);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(200, 20);
            this.txtFileName.TabIndex = 17;
            // 
            // cboVideoCodec
            // 
            this.cboVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoCodec.FormattingEnabled = true;
            this.cboVideoCodec.Location = new System.Drawing.Point(138, 47);
            this.cboVideoCodec.Name = "cboVideoCodec";
            this.cboVideoCodec.Size = new System.Drawing.Size(200, 21);
            this.cboVideoCodec.TabIndex = 16;
            // 
            // cboMediaStreamContainer
            // 
            this.cboMediaStreamContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMediaStreamContainer.FormattingEnabled = true;
            this.cboMediaStreamContainer.Location = new System.Drawing.Point(138, 14);
            this.cboMediaStreamContainer.Name = "cboMediaStreamContainer";
            this.cboMediaStreamContainer.Size = new System.Drawing.Size(200, 21);
            this.cboMediaStreamContainer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Video File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Video Codec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Video File Type";
            // 
            // SaveVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 162);
            this.Controls.Add(this.chkPause);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.btnStopCapture);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.cboVideoCodec);
            this.Controls.Add(this.cboMediaStreamContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaveVideoForm";
            this.Text = "SaveVideoForm";
            this.Load += new System.EventHandler(this.SaveVideoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPause;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Button btnStopCapture;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.MaskedTextBox txtFileName;
        private System.Windows.Forms.ComboBox cboVideoCodec;
        private System.Windows.Forms.ComboBox cboMediaStreamContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}