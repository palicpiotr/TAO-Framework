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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawWindow = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackBarBox = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBox)).BeginInit();
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
            this.DrawWindow.Location = new System.Drawing.Point(12, 12);
            this.DrawWindow.Name = "DrawWindow";
            this.DrawWindow.Size = new System.Drawing.Size(698, 474);
            this.DrawWindow.StencilBits = ((byte)(0));
            this.DrawWindow.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // trackBarBox
            // 
            this.trackBarBox.Location = new System.Drawing.Point(715, 66);
            this.trackBarBox.Maximum = 360;
            this.trackBarBox.Name = "trackBarBox";
            this.trackBarBox.Size = new System.Drawing.Size(308, 45);
            this.trackBarBox.TabIndex = 1;
            this.trackBarBox.ValueChanged += new System.EventHandler(this.OnBoxBarChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вращение куба";
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Location = new System.Drawing.Point(719, 13);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(177, 17);
            this.checkBoxAnimation.TabIndex = 3;
            this.checkBoxAnimation.Text = "Неконтролируемая анимация";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.OnAnimationChenged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 130);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выполнил ст.гр. ПРИм-116\r\nСтрадомский О.Д. \r\nВариант №3 - магазин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAnimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBox);
            this.Controls.Add(this.DrawWindow);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Course Project";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBox)).EndInit();
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
        private System.Windows.Forms.Label label3;
    }
}

