namespace GL.PalicPG.Prim_117.LW6
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
            this.AxisComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TrackBarX = new System.Windows.Forms.TrackBar();
            this.TrackBarY = new System.Windows.Forms.TrackBar();
            this.TrackBarZ = new System.Windows.Forms.TrackBar();
            this.TrackBarAngle = new System.Windows.Forms.TrackBar();
            this.TrackBarZoom = new System.Windows.Forms.TrackBar();
            this.LabelX = new System.Windows.Forms.Label();
            this.LableY = new System.Windows.Forms.Label();
            this.LabelZ = new System.Windows.Forms.Label();
            this.LabelAngle = new System.Windows.Forms.Label();
            this.LabelZoom = new System.Windows.Forms.Label();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openASEModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).BeginInit();
            this.MenuStrip.SuspendLayout();
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
            this.SimpleOpenGlControl.Location = new System.Drawing.Point(7, 37);
            this.SimpleOpenGlControl.Name = "SimpleOpenGlControl";
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(761, 719);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 0;
            // 
            // AxisComboBox
            // 
            this.AxisComboBox.FormattingEnabled = true;
            this.AxisComboBox.Items.AddRange(new object[] {
            "by X",
            "by Y",
            "by Z"});
            this.AxisComboBox.Location = new System.Drawing.Point(789, 70);
            this.AxisComboBox.Name = "AxisComboBox";
            this.AxisComboBox.Size = new System.Drawing.Size(245, 24);
            this.AxisComboBox.TabIndex = 1;
            this.AxisComboBox.SelectedIndexChanged += new System.EventHandler(this.AxisComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "AXIS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(789, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Wired";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.X);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(931, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(998, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1094, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Zoom";
            // 
            // TrackBarX
            // 
            this.TrackBarX.Location = new System.Drawing.Point(783, 194);
            this.TrackBarX.Maximum = 50000;
            this.TrackBarX.Minimum = -50000;
            this.TrackBarX.Name = "TrackBarX";
            this.TrackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarX.Size = new System.Drawing.Size(56, 492);
            this.TrackBarX.TabIndex = 9;
            this.TrackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // TrackBarY
            // 
            this.TrackBarY.Location = new System.Drawing.Point(852, 194);
            this.TrackBarY.Maximum = 50000;
            this.TrackBarY.Minimum = -50000;
            this.TrackBarY.Name = "TrackBarY";
            this.TrackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarY.Size = new System.Drawing.Size(56, 492);
            this.TrackBarY.TabIndex = 10;
            this.TrackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
            // 
            // TrackBarZ
            // 
            this.TrackBarZ.Location = new System.Drawing.Point(920, 194);
            this.TrackBarZ.Maximum = 50000;
            this.TrackBarZ.Minimum = -50000;
            this.TrackBarZ.Name = "TrackBarZ";
            this.TrackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZ.Size = new System.Drawing.Size(56, 492);
            this.TrackBarZ.TabIndex = 11;
            this.TrackBarZ.Scroll += new System.EventHandler(this.TrackBarZ_Scroll);
            // 
            // TrackBarAngle
            // 
            this.TrackBarAngle.Location = new System.Drawing.Point(1003, 194);
            this.TrackBarAngle.Maximum = 360;
            this.TrackBarAngle.Minimum = -360;
            this.TrackBarAngle.Name = "TrackBarAngle";
            this.TrackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAngle.Size = new System.Drawing.Size(56, 492);
            this.TrackBarAngle.TabIndex = 12;
            this.TrackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
            // 
            // TrackBarZoom
            // 
            this.TrackBarZoom.Location = new System.Drawing.Point(1097, 194);
            this.TrackBarZoom.Maximum = 5000;
            this.TrackBarZoom.Minimum = -5000;
            this.TrackBarZoom.Name = "TrackBarZoom";
            this.TrackBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZoom.Size = new System.Drawing.Size(56, 492);
            this.TrackBarZoom.TabIndex = 13;
            this.TrackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoom_Scroll);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(792, 689);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(17, 17);
            this.LabelX.TabIndex = 14;
            this.LabelX.Text = "X";
            // 
            // LableY
            // 
            this.LableY.AutoSize = true;
            this.LableY.Location = new System.Drawing.Point(864, 689);
            this.LableY.Name = "LableY";
            this.LableY.Size = new System.Drawing.Size(17, 17);
            this.LableY.TabIndex = 15;
            this.LableY.Text = "Y";
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Location = new System.Drawing.Point(926, 689);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(17, 17);
            this.LabelZ.TabIndex = 16;
            this.LabelZ.Text = "Z";
            // 
            // LabelAngle
            // 
            this.LabelAngle.AutoSize = true;
            this.LabelAngle.Location = new System.Drawing.Point(1000, 689);
            this.LabelAngle.Name = "LabelAngle";
            this.LabelAngle.Size = new System.Drawing.Size(46, 17);
            this.LabelAngle.TabIndex = 17;
            this.LabelAngle.Text = "label7";
            // 
            // LabelZoom
            // 
            this.LabelZoom.AutoSize = true;
            this.LabelZoom.Location = new System.Drawing.Point(1092, 689);
            this.LabelZoom.Name = "LabelZoom";
            this.LabelZoom.Size = new System.Drawing.Size(44, 17);
            this.LabelZoom.TabIndex = 18;
            this.LabelZoom.Text = "Zoom";
            // 
            // RenderTimer
            // 
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1251, 28);
            this.MenuStrip.TabIndex = 19;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openASEModelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openASEModelToolStripMenuItem
            // 
            this.openASEModelToolStripMenuItem.Name = "openASEModelToolStripMenuItem";
            this.openASEModelToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.openASEModelToolStripMenuItem.Text = "Open ASE Model";
            this.openASEModelToolStripMenuItem.Click += new System.EventHandler(this.OpenASEModelToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 768);
            this.Controls.Add(this.LabelZoom);
            this.Controls.Add(this.LabelAngle);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.LableY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.TrackBarZoom);
            this.Controls.Add(this.TrackBarAngle);
            this.Controls.Add(this.TrackBarZ);
            this.Controls.Add(this.TrackBarY);
            this.Controls.Add(this.TrackBarX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AxisComboBox);
            this.Controls.Add(this.SimpleOpenGlControl);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl SimpleOpenGlControl;
        private System.Windows.Forms.ComboBox AxisComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar TrackBarX;
        private System.Windows.Forms.TrackBar TrackBarY;
        private System.Windows.Forms.TrackBar TrackBarZ;
        private System.Windows.Forms.TrackBar TrackBarAngle;
        private System.Windows.Forms.TrackBar TrackBarZoom;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LableY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label LabelAngle;
        private System.Windows.Forms.Label LabelZoom;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASEModelToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

