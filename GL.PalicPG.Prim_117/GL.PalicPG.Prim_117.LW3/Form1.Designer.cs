namespace GL.PalicPG.Prim_117.LW3
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.objectTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objectStyles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.axis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackX = new System.Windows.Forms.TrackBar();
            this.trackY = new System.Windows.Forms.TrackBar();
            this.trackZ = new System.Windows.Forms.TrackBar();
            this.trackAngle = new System.Windows.Forms.TrackBar();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.lX = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lZ = new System.Windows.Forms.Label();
            this.lA = new System.Windows.Forms.Label();
            this.lZoom = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lXD = new System.Windows.Forms.Label();
            this.lYD = new System.Windows.Forms.Label();
            this.lZD = new System.Windows.Forms.Label();
            this.lAD = new System.Windows.Forms.Label();
            this.lZoomD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(12, 12);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(601, 549);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            // 
            // objectTypes
            // 
            this.objectTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectTypes.FormattingEnabled = true;
            this.objectTypes.Items.AddRange(new object[] {
            "Sphere",
            "Cylinder",
            "Cube",
            "Coone",
            "Torus"});
            this.objectTypes.Location = new System.Drawing.Point(624, 37);
            this.objectTypes.Name = "objectTypes";
            this.objectTypes.Size = new System.Drawing.Size(300, 24);
            this.objectTypes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select object";
            // 
            // objectStyles
            // 
            this.objectStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectStyles.FormattingEnabled = true;
            this.objectStyles.Items.AddRange(new object[] {
            "Wired",
            "Quads"});
            this.objectStyles.Location = new System.Drawing.Point(624, 113);
            this.objectStyles.Name = "objectStyles";
            this.objectStyles.Size = new System.Drawing.Size(300, 24);
            this.objectStyles.TabIndex = 5;
            this.objectStyles.SelectedIndexChanged += new System.EventHandler(this.ObjectStyles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select object style";
            // 
            // axis
            // 
            this.axis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axis.FormattingEnabled = true;
            this.axis.Items.AddRange(new object[] {
            "by X",
            "by Y",
            "by Z"});
            this.axis.Location = new System.Drawing.Point(624, 185);
            this.axis.Name = "axis";
            this.axis.Size = new System.Drawing.Size(300, 24);
            this.axis.TabIndex = 7;
            this.axis.SelectedIndexChanged += new System.EventHandler(this.Axis_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select AXIS Or";
            // 
            // trackX
            // 
            this.trackX.Location = new System.Drawing.Point(639, 243);
            this.trackX.Maximum = 40000;
            this.trackX.Minimum = -40000;
            this.trackX.Name = "trackX";
            this.trackX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackX.Size = new System.Drawing.Size(56, 318);
            this.trackX.TabIndex = 9;
            this.trackX.Scroll += new System.EventHandler(this.TrackX_Scroll);
            // 
            // trackY
            // 
            this.trackY.Location = new System.Drawing.Point(694, 243);
            this.trackY.Maximum = 40000;
            this.trackY.Minimum = -40000;
            this.trackY.Name = "trackY";
            this.trackY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackY.Size = new System.Drawing.Size(56, 318);
            this.trackY.TabIndex = 15;
            this.trackY.Scroll += new System.EventHandler(this.TrackY_Scroll);
            // 
            // trackZ
            // 
            this.trackZ.Location = new System.Drawing.Point(747, 243);
            this.trackZ.Maximum = 40000;
            this.trackZ.Minimum = -40000;
            this.trackZ.Name = "trackZ";
            this.trackZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackZ.Size = new System.Drawing.Size(56, 318);
            this.trackZ.TabIndex = 16;
            this.trackZ.Scroll += new System.EventHandler(this.TrackZ_Scroll);
            // 
            // trackAngle
            // 
            this.trackAngle.Location = new System.Drawing.Point(809, 243);
            this.trackAngle.Maximum = 360;
            this.trackAngle.Minimum = -360;
            this.trackAngle.Name = "trackAngle";
            this.trackAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackAngle.Size = new System.Drawing.Size(56, 318);
            this.trackAngle.TabIndex = 17;
            this.trackAngle.Scroll += new System.EventHandler(this.TrackAngle_Scroll);
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(871, 243);
            this.trackZoom.Maximum = 5000;
            this.trackZoom.Minimum = -5000;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackZoom.Size = new System.Drawing.Size(56, 318);
            this.trackZoom.TabIndex = 18;
            this.trackZoom.Scroll += new System.EventHandler(this.TrackZoom_Scroll);
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(645, 223);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(17, 17);
            this.lX.TabIndex = 12;
            this.lX.Text = "X";
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(701, 223);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(17, 17);
            this.lY.TabIndex = 13;
            this.lY.Text = "Y";
            // 
            // lZ
            // 
            this.lZ.AutoSize = true;
            this.lZ.Location = new System.Drawing.Point(756, 223);
            this.lZ.Name = "lZ";
            this.lZ.Size = new System.Drawing.Size(17, 17);
            this.lZ.TabIndex = 14;
            this.lZ.Text = "Z";
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(810, 223);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(44, 17);
            this.lA.TabIndex = 15;
            this.lA.Text = "Angle";
            // 
            // lZoom
            // 
            this.lZoom.AutoSize = true;
            this.lZoom.Location = new System.Drawing.Point(872, 223);
            this.lZoom.Name = "lZoom";
            this.lZoom.Size = new System.Drawing.Size(44, 17);
            this.lZoom.TabIndex = 16;
            this.lZoom.Text = "Zoom";
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.RedrawSurface_Tick);
            // 
            // lXD
            // 
            this.lXD.AutoSize = true;
            this.lXD.Location = new System.Drawing.Point(645, 564);
            this.lXD.Name = "lXD";
            this.lXD.Size = new System.Drawing.Size(17, 17);
            this.lXD.TabIndex = 19;
            this.lXD.Text = "X";
            // 
            // lYD
            // 
            this.lYD.AutoSize = true;
            this.lYD.Location = new System.Drawing.Point(701, 564);
            this.lYD.Name = "lYD";
            this.lYD.Size = new System.Drawing.Size(17, 17);
            this.lYD.TabIndex = 20;
            this.lYD.Text = "Y";
            // 
            // lZD
            // 
            this.lZD.AutoSize = true;
            this.lZD.Location = new System.Drawing.Point(756, 564);
            this.lZD.Name = "lZD";
            this.lZD.Size = new System.Drawing.Size(17, 17);
            this.lZD.TabIndex = 21;
            this.lZD.Text = "Z";
            // 
            // lAD
            // 
            this.lAD.AutoSize = true;
            this.lAD.Location = new System.Drawing.Point(806, 564);
            this.lAD.Name = "lAD";
            this.lAD.Size = new System.Drawing.Size(44, 17);
            this.lAD.TabIndex = 22;
            this.lAD.Text = "Angle";
            // 
            // lZoomD
            // 
            this.lZoomD.AutoSize = true;
            this.lZoomD.Location = new System.Drawing.Point(872, 564);
            this.lZoomD.Name = "lZoomD";
            this.lZoomD.Size = new System.Drawing.Size(44, 17);
            this.lZoomD.TabIndex = 23;
            this.lZoomD.Text = "Zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 653);
            this.Controls.Add(this.lZoomD);
            this.Controls.Add(this.lAD);
            this.Controls.Add(this.lZD);
            this.Controls.Add(this.lYD);
            this.Controls.Add(this.lXD);
            this.Controls.Add(this.lZoom);
            this.Controls.Add(this.lA);
            this.Controls.Add(this.lZ);
            this.Controls.Add(this.lY);
            this.Controls.Add(this.lX);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.trackAngle);
            this.Controls.Add(this.trackZ);
            this.Controls.Add(this.trackY);
            this.Controls.Add(this.trackX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.axis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objectStyles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectTypes);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.ComboBox objectTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objectStyles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox axis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackX;
        private System.Windows.Forms.TrackBar trackY;
        private System.Windows.Forms.TrackBar trackZ;
        private System.Windows.Forms.TrackBar trackAngle;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lZ;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label lZoom;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lXD;
        private System.Windows.Forms.Label lYD;
        private System.Windows.Forms.Label lZD;
        private System.Windows.Forms.Label lAD;
        private System.Windows.Forms.Label lZoomD;
    }
}

