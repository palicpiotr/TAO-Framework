namespace GL.PalicPG.Prim_117.LW4
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
            this.components = new System.ComponentModel.Container();
            this.SimpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.BangButton = new System.Windows.Forms.Button();
            this.BangLast = new System.Windows.Forms.Button();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackBarX = new System.Windows.Forms.TrackBar();
            this.TrackBarY = new System.Windows.Forms.TrackBar();
            this.TrackBarZ = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackByX = new System.Windows.Forms.CheckBox();
            this.TrackByY = new System.Windows.Forms.CheckBox();
            this.TrackByZ = new System.Windows.Forms.CheckBox();
            this.TrackBarDeg = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDeg)).BeginInit();
            this.SuspendLayout();
            // 
            // SimpleOpenGlControl
            // 
            this.SimpleOpenGlControl.AccumBits = ((byte)(0));
            this.SimpleOpenGlControl.AutoCheckErrors = false;
            this.SimpleOpenGlControl.AutoFinish = false;
            this.SimpleOpenGlControl.AutoMakeCurrent = true;
            this.SimpleOpenGlControl.AutoSwapBuffers = true;
            this.SimpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this.SimpleOpenGlControl.ColorBits = ((byte)(32));
            this.SimpleOpenGlControl.DepthBits = ((byte)(16));
            this.SimpleOpenGlControl.Location = new System.Drawing.Point(7, 9);
            this.SimpleOpenGlControl.Name = "SimpleOpenGlControl";
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(880, 699);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 0;
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 30;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // BangButton
            // 
            this.BangButton.Location = new System.Drawing.Point(908, 18);
            this.BangButton.Name = "BangButton";
            this.BangButton.Size = new System.Drawing.Size(171, 32);
            this.BangButton.TabIndex = 1;
            this.BangButton.Text = "Baaang";
            this.BangButton.UseVisualStyleBackColor = true;
            this.BangButton.Click += new System.EventHandler(this.BangButton_Click);
            // 
            // BangLast
            // 
            this.BangLast.Location = new System.Drawing.Point(1085, 19);
            this.BangLast.Name = "BangLast";
            this.BangLast.Size = new System.Drawing.Size(166, 31);
            this.BangLast.TabIndex = 2;
            this.BangLast.Text = "Find last and Bang";
            this.BangLast.UseVisualStyleBackColor = true;
            this.BangLast.Click += new System.EventHandler(this.BangLast_Click);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "Cam 1",
            "Cam 2",
            "Cam 3",
            "FIND WEI"});
            this.PositionComboBox.Location = new System.Drawing.Point(908, 109);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(171, 24);
            this.PositionComboBox.TabIndex = 3;
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "White",
            "Black"});
            this.ModeComboBox.Location = new System.Drawing.Point(1085, 109);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(166, 24);
            this.ModeComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(908, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cam position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1082, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mode";
            // 
            // TrackBarX
            // 
            this.TrackBarX.Location = new System.Drawing.Point(925, 180);
            this.TrackBarX.Maximum = 20;
            this.TrackBarX.Minimum = -20;
            this.TrackBarX.Name = "TrackBarX";
            this.TrackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarX.Size = new System.Drawing.Size(56, 487);
            this.TrackBarX.TabIndex = 7;
            // 
            // TrackBarY
            // 
            this.TrackBarY.Location = new System.Drawing.Point(1036, 180);
            this.TrackBarY.Maximum = 20;
            this.TrackBarY.Minimum = -20;
            this.TrackBarY.Name = "TrackBarY";
            this.TrackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarY.Size = new System.Drawing.Size(56, 487);
            this.TrackBarY.TabIndex = 8;
            // 
            // TrackBarZ
            // 
            this.TrackBarZ.Location = new System.Drawing.Point(1152, 180);
            this.TrackBarZ.Maximum = 20;
            this.TrackBarZ.Minimum = -20;
            this.TrackBarZ.Name = "TrackBarZ";
            this.TrackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZ.Size = new System.Drawing.Size(56, 487);
            this.TrackBarZ.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // TrackByX
            // 
            this.TrackByX.AutoSize = true;
            this.TrackByX.Location = new System.Drawing.Point(925, 682);
            this.TrackByX.Name = "TrackByX";
            this.TrackByX.Size = new System.Drawing.Size(59, 21);
            this.TrackByX.TabIndex = 11;
            this.TrackByX.Text = "By X";
            this.TrackByX.UseVisualStyleBackColor = true;
            // 
            // TrackByY
            // 
            this.TrackByY.AutoSize = true;
            this.TrackByY.Location = new System.Drawing.Point(1027, 682);
            this.TrackByY.Name = "TrackByY";
            this.TrackByY.Size = new System.Drawing.Size(59, 21);
            this.TrackByY.TabIndex = 12;
            this.TrackByY.Text = "By Y";
            this.TrackByY.UseVisualStyleBackColor = true;
            // 
            // TrackByZ
            // 
            this.TrackByZ.AutoSize = true;
            this.TrackByZ.Location = new System.Drawing.Point(1152, 682);
            this.TrackByZ.Name = "TrackByZ";
            this.TrackByZ.Size = new System.Drawing.Size(59, 21);
            this.TrackByZ.TabIndex = 13;
            this.TrackByZ.Text = "By Z";
            this.TrackByZ.UseVisualStyleBackColor = true;
            // 
            // TrackBarDeg
            // 
            this.TrackBarDeg.Location = new System.Drawing.Point(1243, 180);
            this.TrackBarDeg.Maximum = 180;
            this.TrackBarDeg.Minimum = -180;
            this.TrackBarDeg.Name = "TrackBarDeg";
            this.TrackBarDeg.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarDeg.Size = new System.Drawing.Size(56, 487);
            this.TrackBarDeg.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 719);
            this.Controls.Add(this.TrackBarDeg);
            this.Controls.Add(this.TrackByZ);
            this.Controls.Add(this.TrackByY);
            this.Controls.Add(this.TrackByX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackBarZ);
            this.Controls.Add(this.TrackBarY);
            this.Controls.Add(this.TrackBarX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModeComboBox);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.BangLast);
            this.Controls.Add(this.BangButton);
            this.Controls.Add(this.SimpleOpenGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl SimpleOpenGlControl;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Button BangButton;
        private System.Windows.Forms.Button BangLast;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrackBarX;
        private System.Windows.Forms.TrackBar TrackBarY;
        private System.Windows.Forms.TrackBar TrackBarZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox TrackByX;
        private System.Windows.Forms.CheckBox TrackByY;
        private System.Windows.Forms.CheckBox TrackByZ;
        private System.Windows.Forms.TrackBar TrackBarDeg;
    }
}

