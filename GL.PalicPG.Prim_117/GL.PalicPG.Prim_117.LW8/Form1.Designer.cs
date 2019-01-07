namespace GL.PalicPG.Prim_117.LW8
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AxisComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWiredObject = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelZ = new System.Windows.Forms.Label();
            this.LabelAngle = new System.Windows.Forms.Label();
            this.LabelZoom = new System.Windows.Forms.Label();
            this.TrackBarX = new System.Windows.Forms.TrackBar();
            this.TrackBarY = new System.Windows.Forms.TrackBar();
            this.TRackBarZ = new System.Windows.Forms.TrackBar();
            this.TrackBarAngle = new System.Windows.Forms.TrackBar();
            this.TrackBarZoom = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabelOrthoFar = new System.Windows.Forms.Label();
            this.TrackBarOrthoFar = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelPerspectiveFar = new System.Windows.Forms.Label();
            this.TrackBarPerspectiveFar = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TrackBarFrustumFar = new System.Windows.Forms.TrackBar();
            this.LabelFrustumFar = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOrthoFar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPerspectiveFar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrustumFar)).BeginInit();
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
            this.SimpleOpenGlControl.Location = new System.Drawing.Point(9, 43);
            this.SimpleOpenGlControl.Name = "SimpleOpenGlControl";
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(778, 704);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 0;
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
            this.MenuStrip.Size = new System.Drawing.Size(1187, 28);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openModelToolStripMenuItem
            // 
            this.openModelToolStripMenuItem.Name = "openModelToolStripMenuItem";
            this.openModelToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.openModelToolStripMenuItem.Text = "Open Model";
            this.openModelToolStripMenuItem.Click += new System.EventHandler(this.OpenModelToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // AxisComboBox
            // 
            this.AxisComboBox.FormattingEnabled = true;
            this.AxisComboBox.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.AxisComboBox.Location = new System.Drawing.Point(793, 72);
            this.AxisComboBox.Name = "AxisComboBox";
            this.AxisComboBox.Size = new System.Drawing.Size(315, 24);
            this.AxisComboBox.TabIndex = 2;
            this.AxisComboBox.SelectedIndexChanged += new System.EventHandler(this.AxisComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "AXIS";
            // 
            // checkBoxWiredObject
            // 
            this.checkBoxWiredObject.AutoSize = true;
            this.checkBoxWiredObject.Location = new System.Drawing.Point(796, 102);
            this.checkBoxWiredObject.Name = "checkBoxWiredObject";
            this.checkBoxWiredObject.Size = new System.Drawing.Size(67, 21);
            this.checkBoxWiredObject.TabIndex = 4;
            this.checkBoxWiredObject.Text = "Wired";
            this.checkBoxWiredObject.UseVisualStyleBackColor = true;
            this.checkBoxWiredObject.CheckedChanged += new System.EventHandler(this.CheckBoxWiredObject_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1021, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1110, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Zoom";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(814, 730);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(17, 17);
            this.LabelX.TabIndex = 10;
            this.LabelX.Text = "X";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(879, 730);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(17, 17);
            this.LabelY.TabIndex = 11;
            this.LabelY.Text = "Y";
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Location = new System.Drawing.Point(945, 730);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(17, 17);
            this.LabelZ.TabIndex = 12;
            this.LabelZ.Text = "Z";
            // 
            // LabelAngle
            // 
            this.LabelAngle.AutoSize = true;
            this.LabelAngle.Location = new System.Drawing.Point(1021, 730);
            this.LabelAngle.Name = "LabelAngle";
            this.LabelAngle.Size = new System.Drawing.Size(44, 17);
            this.LabelAngle.TabIndex = 13;
            this.LabelAngle.Text = "Angle";
            // 
            // LabelZoom
            // 
            this.LabelZoom.AutoSize = true;
            this.LabelZoom.Location = new System.Drawing.Point(1110, 730);
            this.LabelZoom.Name = "LabelZoom";
            this.LabelZoom.Size = new System.Drawing.Size(44, 17);
            this.LabelZoom.TabIndex = 14;
            this.LabelZoom.Text = "Zoom";
            // 
            // TrackBarX
            // 
            this.TrackBarX.Location = new System.Drawing.Point(807, 171);
            this.TrackBarX.Maximum = 50000;
            this.TrackBarX.Minimum = -50000;
            this.TrackBarX.Name = "TrackBarX";
            this.TrackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarX.Size = new System.Drawing.Size(56, 556);
            this.TrackBarX.TabIndex = 15;
            this.TrackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // TrackBarY
            // 
            this.TrackBarY.Location = new System.Drawing.Point(869, 171);
            this.TrackBarY.Maximum = 50000;
            this.TrackBarY.Minimum = -50000;
            this.TrackBarY.Name = "TrackBarY";
            this.TrackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarY.Size = new System.Drawing.Size(56, 556);
            this.TrackBarY.TabIndex = 16;
            this.TrackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
            // 
            // TRackBarZ
            // 
            this.TRackBarZ.Location = new System.Drawing.Point(922, 171);
            this.TRackBarZ.Maximum = 50000;
            this.TRackBarZ.Minimum = -50000;
            this.TRackBarZ.Name = "TRackBarZ";
            this.TRackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TRackBarZ.Size = new System.Drawing.Size(56, 556);
            this.TRackBarZ.TabIndex = 17;
            this.TRackBarZ.Scroll += new System.EventHandler(this.TRackBarZ_Scroll);
            // 
            // TrackBarAngle
            // 
            this.TrackBarAngle.Location = new System.Drawing.Point(1024, 171);
            this.TrackBarAngle.Maximum = 360;
            this.TrackBarAngle.Minimum = -360;
            this.TrackBarAngle.Name = "TrackBarAngle";
            this.TrackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAngle.Size = new System.Drawing.Size(56, 556);
            this.TrackBarAngle.TabIndex = 18;
            this.TrackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
            // 
            // TrackBarZoom
            // 
            this.TrackBarZoom.Location = new System.Drawing.Point(1113, 171);
            this.TrackBarZoom.Maximum = 5000;
            this.TrackBarZoom.Minimum = -5000;
            this.TrackBarZoom.Name = "TrackBarZoom";
            this.TrackBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZoom.Size = new System.Drawing.Size(56, 556);
            this.TrackBarZoom.TabIndex = 19;
            this.TrackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoom_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 772);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 156);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelOrthoFar);
            this.tabPage1.Controls.Add(this.TrackBarOrthoFar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ortho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LabelOrthoFar
            // 
            this.LabelOrthoFar.AutoSize = true;
            this.LabelOrthoFar.Location = new System.Drawing.Point(50, 16);
            this.LabelOrthoFar.Name = "LabelOrthoFar";
            this.LabelOrthoFar.Size = new System.Drawing.Size(29, 17);
            this.LabelOrthoFar.TabIndex = 1;
            this.LabelOrthoFar.Text = "Far";
            // 
            // TrackBarOrthoFar
            // 
            this.TrackBarOrthoFar.Location = new System.Drawing.Point(34, 47);
            this.TrackBarOrthoFar.Maximum = 200;
            this.TrackBarOrthoFar.Minimum = 1;
            this.TrackBarOrthoFar.Name = "TrackBarOrthoFar";
            this.TrackBarOrthoFar.Size = new System.Drawing.Size(1055, 56);
            this.TrackBarOrthoFar.TabIndex = 0;
            this.TrackBarOrthoFar.Value = 60;
            this.TrackBarOrthoFar.Scroll += new System.EventHandler(this.TrackBarOrthoFar_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabelPerspectiveFar);
            this.tabPage2.Controls.Add(this.TrackBarPerspectiveFar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perspective";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabelPerspectiveFar
            // 
            this.LabelPerspectiveFar.AutoSize = true;
            this.LabelPerspectiveFar.Location = new System.Drawing.Point(26, 26);
            this.LabelPerspectiveFar.Name = "LabelPerspectiveFar";
            this.LabelPerspectiveFar.Size = new System.Drawing.Size(29, 17);
            this.LabelPerspectiveFar.TabIndex = 4;
            this.LabelPerspectiveFar.Text = "Far";
            // 
            // TrackBarPerspectiveFar
            // 
            this.TrackBarPerspectiveFar.Location = new System.Drawing.Point(18, 63);
            this.TrackBarPerspectiveFar.Maximum = 180;
            this.TrackBarPerspectiveFar.Name = "TrackBarPerspectiveFar";
            this.TrackBarPerspectiveFar.Size = new System.Drawing.Size(1073, 56);
            this.TrackBarPerspectiveFar.TabIndex = 2;
            this.TrackBarPerspectiveFar.Value = 90;
            this.TrackBarPerspectiveFar.Scroll += new System.EventHandler(this.TrackBarPerspectiveFar_Scroll);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TrackBarFrustumFar);
            this.tabPage3.Controls.Add(this.LabelFrustumFar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1128, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Frustlum";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TrackBarFrustumFar
            // 
            this.TrackBarFrustumFar.Location = new System.Drawing.Point(13, 55);
            this.TrackBarFrustumFar.Maximum = 200;
            this.TrackBarFrustumFar.Name = "TrackBarFrustumFar";
            this.TrackBarFrustumFar.Size = new System.Drawing.Size(1079, 56);
            this.TrackBarFrustumFar.TabIndex = 1;
            this.TrackBarFrustumFar.Value = 60;
            this.TrackBarFrustumFar.Scroll += new System.EventHandler(this.TrackBarFrustumFar_Scroll);
            // 
            // LabelFrustumFar
            // 
            this.LabelFrustumFar.AutoSize = true;
            this.LabelFrustumFar.Location = new System.Drawing.Point(10, 21);
            this.LabelFrustumFar.Name = "LabelFrustumFar";
            this.LabelFrustumFar.Size = new System.Drawing.Size(29, 17);
            this.LabelFrustumFar.TabIndex = 0;
            this.LabelFrustumFar.Text = "Far";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 932);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TrackBarZoom);
            this.Controls.Add(this.TrackBarAngle);
            this.Controls.Add(this.TRackBarZ);
            this.Controls.Add(this.TrackBarY);
            this.Controls.Add(this.TrackBarX);
            this.Controls.Add(this.LabelZoom);
            this.Controls.Add(this.LabelAngle);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxWiredObject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AxisComboBox);
            this.Controls.Add(this.SimpleOpenGlControl);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOrthoFar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPerspectiveFar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrustumFar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl SimpleOpenGlControl;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ComboBox AxisComboBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxWiredObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label LabelAngle;
        private System.Windows.Forms.Label LabelZoom;
        private System.Windows.Forms.TrackBar TrackBarX;
        private System.Windows.Forms.TrackBar TrackBarY;
        private System.Windows.Forms.TrackBar TRackBarZ;
        private System.Windows.Forms.TrackBar TrackBarAngle;
        private System.Windows.Forms.TrackBar TrackBarZoom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LabelOrthoFar;
        private System.Windows.Forms.TrackBar TrackBarOrthoFar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LabelPerspectiveFar;
        private System.Windows.Forms.TrackBar TrackBarPerspectiveFar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar TrackBarFrustumFar;
        private System.Windows.Forms.Label LabelFrustumFar;
    }
}

