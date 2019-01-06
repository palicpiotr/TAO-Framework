namespace GL.PalicPG.Prim_117.LW2
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.comboBoxObjectType = new System.Windows.Forms.ComboBox();
            this.comboBoxRenderMode = new System.Windows.Forms.ComboBox();
            this.comboBoxFigureStyle = new System.Windows.Forms.ComboBox();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarSmooth = new System.Windows.Forms.TrackBar();
            this.trackBarParam = new System.Windows.Forms.TrackBar();
            this.checkBoxRotation = new System.Windows.Forms.CheckBox();
            this.buttonRotation = new System.Windows.Forms.Button();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarParam)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(473, 426);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // comboBoxObjectType
            // 
            this.comboBoxObjectType.FormattingEnabled = true;
            this.comboBoxObjectType.Items.AddRange(new object[] {
            "Torus",
            "Superellipse",
            "Bézier surface",
            "B-spline surface"});
            this.comboBoxObjectType.Location = new System.Drawing.Point(526, 25);
            this.comboBoxObjectType.Name = "comboBoxObjectType";
            this.comboBoxObjectType.Size = new System.Drawing.Size(241, 24);
            this.comboBoxObjectType.TabIndex = 1;
            this.comboBoxObjectType.TabIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBoxRenderMode
            // 
            this.comboBoxRenderMode.FormattingEnabled = true;
            this.comboBoxRenderMode.Items.AddRange(new object[] {
            "Equation",
            "OpenGL, GLUT"});
            this.comboBoxRenderMode.Location = new System.Drawing.Point(527, 85);
            this.comboBoxRenderMode.Name = "comboBoxRenderMode";
            this.comboBoxRenderMode.Size = new System.Drawing.Size(239, 24);
            this.comboBoxRenderMode.TabIndex = 2;
            // 
            // comboBoxFigureStyle
            // 
            this.comboBoxFigureStyle.FormattingEnabled = true;
            this.comboBoxFigureStyle.Items.AddRange(new object[] {
            "GL_POINTS",
            "GL_LINES",
            "GL_QUADS"});
            this.comboBoxFigureStyle.Location = new System.Drawing.Point(526, 145);
            this.comboBoxFigureStyle.Name = "comboBoxFigureStyle";
            this.comboBoxFigureStyle.Size = new System.Drawing.Size(240, 24);
            this.comboBoxFigureStyle.TabIndex = 3;
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 2;
            this.trackBarSize.Location = new System.Drawing.Point(529, 230);
            this.trackBarSize.Maximum = 50;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(236, 56);
            this.trackBarSize.TabIndex = 7;
            this.trackBarSize.Scroll += new System.EventHandler(this.TrackBarSize_Scroll);
            // 
            // trackBarSmooth
            // 
            this.trackBarSmooth.Location = new System.Drawing.Point(526, 293);
            this.trackBarSmooth.Maximum = 64;
            this.trackBarSmooth.Name = "trackBarSmooth";
            this.trackBarSmooth.Size = new System.Drawing.Size(238, 56);
            this.trackBarSmooth.TabIndex = 9;
            this.trackBarSmooth.Scroll += new System.EventHandler(this.TrackBarSmooth_Scroll);
            // 
            // trackBarParam
            // 
            this.trackBarParam.Location = new System.Drawing.Point(531, 359);
            this.trackBarParam.Name = "trackBarParam";
            this.trackBarParam.Size = new System.Drawing.Size(232, 56);
            this.trackBarParam.TabIndex = 6;
            this.trackBarParam.Scroll += new System.EventHandler(this.TrackBarParam_Scroll);
            // 
            // checkBoxRotation
            // 
            this.checkBoxRotation.AutoSize = true;
            this.checkBoxRotation.Location = new System.Drawing.Point(538, 446);
            this.checkBoxRotation.Name = "checkBoxRotation";
            this.checkBoxRotation.Size = new System.Drawing.Size(117, 21);
            this.checkBoxRotation.TabIndex = 10;
            this.checkBoxRotation.Text = "Rotate Object";
            this.checkBoxRotation.UseVisualStyleBackColor = true;
            // 
            // buttonRotation
            // 
            this.buttonRotation.Location = new System.Drawing.Point(686, 446);
            this.buttonRotation.Name = "buttonRotation";
            this.buttonRotation.Size = new System.Drawing.Size(127, 28);
            this.buttonRotation.TabIndex = 11;
            this.buttonRotation.Text = "Rotate";
            this.buttonRotation.UseVisualStyleBackColor = true;
            this.buttonRotation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonRotation_MouseDown);
            this.buttonRotation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonRotation_MouseUp);
            // 
            // renderTimer
            // 
            this.renderTimer.Interval = 30;
            this.renderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 545);
            this.Controls.Add(this.buttonRotation);
            this.Controls.Add(this.checkBoxRotation);
            this.Controls.Add(this.trackBarParam);
            this.Controls.Add(this.trackBarSmooth);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.comboBoxFigureStyle);
            this.Controls.Add(this.comboBoxRenderMode);
            this.Controls.Add(this.comboBoxObjectType);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarParam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox comboBoxObjectType;
        private System.Windows.Forms.ComboBox comboBoxRenderMode;
        private System.Windows.Forms.ComboBox comboBoxFigureStyle;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TrackBar trackBarSmooth;
        private System.Windows.Forms.TrackBar trackBarParam;
        private System.Windows.Forms.CheckBox checkBoxRotation;
        private System.Windows.Forms.Button buttonRotation;
        private System.Windows.Forms.Timer renderTimer;
    }
}

