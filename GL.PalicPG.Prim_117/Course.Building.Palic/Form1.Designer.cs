namespace Course.Building.Palic
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
            this.DrawWindow = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackBarBox = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawWindow
            // 
            this.DrawWindow.AccumBits = ((byte)(0));
            this.DrawWindow.AutoCheckErrors = false;
            this.DrawWindow.AutoFinish = false;
            this.DrawWindow.AutoMakeCurrent = true;
            this.DrawWindow.AutoSwapBuffers = true;
            this.DrawWindow.BackColor = System.Drawing.Color.Black;
            this.DrawWindow.ColorBits = ((byte)(32));
            this.DrawWindow.DepthBits = ((byte)(16));
            this.DrawWindow.Location = new System.Drawing.Point(16, 47);
            this.DrawWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawWindow.Name = "DrawWindow";
            this.DrawWindow.Size = new System.Drawing.Size(931, 583);
            this.DrawWindow.StencilBits = ((byte)(0));
            this.DrawWindow.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // trackBarBox
            // 
            this.trackBarBox.Location = new System.Drawing.Point(979, 127);
            this.trackBarBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBox.Maximum = 360;
            this.trackBarBox.Name = "trackBarBox";
            this.trackBarBox.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBox.Size = new System.Drawing.Size(56, 411);
            this.trackBarBox.TabIndex = 1;
            this.trackBarBox.ValueChanged += new System.EventHandler(this.OnBoxBarChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rotate building block";
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Location = new System.Drawing.Point(959, 45);
            this.checkBoxAnimation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(168, 21);
            this.checkBoxAnimation.TabIndex = 3;
            this.checkBoxAnimation.Text = "Non control animation";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.OnAnimationChenged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotKeysToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hotKeysToolStripMenuItem
            // 
            this.hotKeysToolStripMenuItem.Name = "hotKeysToolStripMenuItem";
            this.hotKeysToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hotKeysToolStripMenuItem.Text = "Hot Keys";
            this.hotKeysToolStripMenuItem.Click += new System.EventHandler(this.HotKeysToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAnimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBox);
            this.Controls.Add(this.DrawWindow);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Course Project";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private Tao.Platform.Windows.SimpleOpenGlControl DrawWindow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar trackBarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAnimation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotKeysToolStripMenuItem;
    }
}

