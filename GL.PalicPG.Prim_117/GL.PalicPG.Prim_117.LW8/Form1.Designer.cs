﻿namespace GL.PalicPG.Prim_117.LW8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SimpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openASEModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextureImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogASEModel = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAxis = new System.Windows.Forms.ComboBox();
            this.checkBoxWired = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackBarX = new System.Windows.Forms.TrackBar();
            this.TrackBarY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackBarZ = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBarAngle = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackBarZoom = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelZoomInfo = new System.Windows.Forms.Label();
            this.labelAngleInfo = new System.Windows.Forms.Label();
            this.labelXinfo = new System.Windows.Forms.Label();
            this.labelYinfo = new System.Windows.Forms.Label();
            this.labelZinfo = new System.Windows.Forms.Label();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControlCam = new System.Windows.Forms.TabControl();
            this.tabPageOrtho = new System.Windows.Forms.TabPage();
            this.TrackBarFarOrtho = new System.Windows.Forms.TrackBar();
            this.labelOrtFar = new System.Windows.Forms.Label();
            this.tabPagePerspective = new System.Windows.Forms.TabPage();
            this.labelPerFar = new System.Windows.Forms.Label();
            this.TrackBarFarPerspective = new System.Windows.Forms.TrackBar();
            this.tabPageFrustum = new System.Windows.Forms.TabPage();
            this.TrackBarFarFrustum = new System.Windows.Forms.TrackBar();
            this.labelFruFar = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.openFileDialogTextureImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComboBoxLightColorSpecularSelect = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBoxLightColorDiffuseSelect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboBoxLightColorAmbientSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Live = new System.Windows.Forms.Label();
            this.TrackBarLightAngle = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxLightOptionSelect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TrackBarLightZ = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxLight0 = new System.Windows.Forms.CheckBox();
            this.checkBoxLight1 = new System.Windows.Forms.CheckBox();
            this.checkBoxLight2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TrackBarLightY = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.TrackBarLightX = new System.Windows.Forms.TrackBar();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).BeginInit();
            this.tabControlCam.SuspendLayout();
            this.tabPageOrtho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarOrtho)).BeginInit();
            this.tabPagePerspective.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarPerspective)).BeginInit();
            this.tabPageFrustum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarFrustum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightZ)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightX)).BeginInit();
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
            this.SimpleOpenGlControl.Location = new System.Drawing.Point(16, 33);
            this.SimpleOpenGlControl.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleOpenGlControl.Name = "SimpleOpenGlControl";
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(800, 738);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1581, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openASEModelToolStripMenuItem,
            this.openTextureImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openASEModelToolStripMenuItem
            // 
            this.openASEModelToolStripMenuItem.Name = "openASEModelToolStripMenuItem";
            this.openASEModelToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.openASEModelToolStripMenuItem.Text = "Open ASE model...";
            this.openASEModelToolStripMenuItem.Click += new System.EventHandler(this.OpenASEModelToolStripMenuItem_Click);
            // 
            // openTextureImageToolStripMenuItem
            // 
            this.openTextureImageToolStripMenuItem.Name = "openTextureImageToolStripMenuItem";
            this.openTextureImageToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.openTextureImageToolStripMenuItem.Text = "Open texture image...";
            this.openTextureImageToolStripMenuItem.Click += new System.EventHandler(this.OpenTextureImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialogASEModel
            // 
            this.openFileDialogASEModel.FileName = "openFileDialog1";
            this.openFileDialogASEModel.Filter = "ASE files (*.ase)|*.ase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "AXIS";
            // 
            // comboBoxAxis
            // 
            this.comboBoxAxis.FormattingEnabled = true;
            this.comboBoxAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.comboBoxAxis.Location = new System.Drawing.Point(824, 69);
            this.comboBoxAxis.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAxis.Name = "comboBoxAxis";
            this.comboBoxAxis.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAxis.TabIndex = 4;
            this.comboBoxAxis.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAxis_SelectedIndexChanged);
            // 
            // checkBoxWired
            // 
            this.checkBoxWired.AutoSize = true;
            this.checkBoxWired.Location = new System.Drawing.Point(824, 118);
            this.checkBoxWired.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWired.Name = "checkBoxWired";
            this.checkBoxWired.Size = new System.Drawing.Size(67, 21);
            this.checkBoxWired.TabIndex = 5;
            this.checkBoxWired.Text = "Wired";
            this.checkBoxWired.UseVisualStyleBackColor = true;
            this.checkBoxWired.CheckedChanged += new System.EventHandler(this.CheckBoxWired_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // TrackBarX
            // 
            this.TrackBarX.Location = new System.Drawing.Point(824, 187);
            this.TrackBarX.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarX.Maximum = 50000;
            this.TrackBarX.Minimum = -50000;
            this.TrackBarX.Name = "TrackBarX";
            this.TrackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarX.Size = new System.Drawing.Size(56, 518);
            this.TrackBarX.TabIndex = 7;
            this.TrackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // TrackBarY
            // 
            this.TrackBarY.Location = new System.Drawing.Point(892, 187);
            this.TrackBarY.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarY.Maximum = 50000;
            this.TrackBarY.Minimum = -50000;
            this.TrackBarY.Name = "TrackBarY";
            this.TrackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarY.Size = new System.Drawing.Size(56, 518);
            this.TrackBarY.TabIndex = 9;
            this.TrackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // TrackBarZ
            // 
            this.TrackBarZ.Location = new System.Drawing.Point(975, 187);
            this.TrackBarZ.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarZ.Maximum = 50000;
            this.TrackBarZ.Minimum = -50000;
            this.TrackBarZ.Name = "TrackBarZ";
            this.TrackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZ.Size = new System.Drawing.Size(56, 518);
            this.TrackBarZ.TabIndex = 11;
            this.TrackBarZ.Scroll += new System.EventHandler(this.TrackBarZ_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // TrackBarAngle
            // 
            this.TrackBarAngle.Location = new System.Drawing.Point(1059, 187);
            this.TrackBarAngle.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarAngle.Maximum = 360;
            this.TrackBarAngle.Minimum = -360;
            this.TrackBarAngle.Name = "TrackBarAngle";
            this.TrackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAngle.Size = new System.Drawing.Size(56, 518);
            this.TrackBarAngle.TabIndex = 13;
            this.TrackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1059, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Angle";
            // 
            // TrackBarZoom
            // 
            this.TrackBarZoom.Location = new System.Drawing.Point(1127, 187);
            this.TrackBarZoom.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarZoom.Maximum = 5000;
            this.TrackBarZoom.Minimum = -5000;
            this.TrackBarZoom.Name = "TrackBarZoom";
            this.TrackBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZoom.Size = new System.Drawing.Size(56, 518);
            this.TrackBarZoom.TabIndex = 15;
            this.TrackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoom_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1127, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zoom";
            // 
            // labelZoomInfo
            // 
            this.labelZoomInfo.AutoSize = true;
            this.labelZoomInfo.Location = new System.Drawing.Point(1127, 709);
            this.labelZoomInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomInfo.Name = "labelZoomInfo";
            this.labelZoomInfo.Size = new System.Drawing.Size(44, 17);
            this.labelZoomInfo.TabIndex = 16;
            this.labelZoomInfo.Text = "Zoom";
            // 
            // labelAngleInfo
            // 
            this.labelAngleInfo.AutoSize = true;
            this.labelAngleInfo.Location = new System.Drawing.Point(1055, 709);
            this.labelAngleInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngleInfo.Name = "labelAngleInfo";
            this.labelAngleInfo.Size = new System.Drawing.Size(44, 17);
            this.labelAngleInfo.TabIndex = 17;
            this.labelAngleInfo.Text = "Angle";
            // 
            // labelXinfo
            // 
            this.labelXinfo.AutoSize = true;
            this.labelXinfo.Location = new System.Drawing.Point(824, 709);
            this.labelXinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXinfo.Name = "labelXinfo";
            this.labelXinfo.Size = new System.Drawing.Size(17, 17);
            this.labelXinfo.TabIndex = 18;
            this.labelXinfo.Text = "X";
            // 
            // labelYinfo
            // 
            this.labelYinfo.AutoSize = true;
            this.labelYinfo.Location = new System.Drawing.Point(892, 709);
            this.labelYinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYinfo.Name = "labelYinfo";
            this.labelYinfo.Size = new System.Drawing.Size(17, 17);
            this.labelYinfo.TabIndex = 19;
            this.labelYinfo.Text = "Y";
            // 
            // labelZinfo
            // 
            this.labelZinfo.AutoSize = true;
            this.labelZinfo.Location = new System.Drawing.Point(971, 709);
            this.labelZinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZinfo.Name = "labelZinfo";
            this.labelZinfo.Size = new System.Drawing.Size(17, 17);
            this.labelZinfo.TabIndex = 20;
            this.labelZinfo.Text = "Z";
            // 
            // renderTimer
            // 
            this.renderTimer.Interval = 30;
            this.renderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // tabControlCam
            // 
            this.tabControlCam.Controls.Add(this.tabPageOrtho);
            this.tabControlCam.Controls.Add(this.tabPagePerspective);
            this.tabControlCam.Controls.Add(this.tabPageFrustum);
            this.tabControlCam.Location = new System.Drawing.Point(16, 779);
            this.tabControlCam.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCam.Name = "tabControlCam";
            this.tabControlCam.SelectedIndex = 0;
            this.tabControlCam.Size = new System.Drawing.Size(1252, 167);
            this.tabControlCam.TabIndex = 21;
            this.tabControlCam.SelectedIndexChanged += new System.EventHandler(this.TabControlCam_SelectedIndexChanged);
            // 
            // tabPageOrtho
            // 
            this.tabPageOrtho.Controls.Add(this.TrackBarFarOrtho);
            this.tabPageOrtho.Controls.Add(this.labelOrtFar);
            this.tabPageOrtho.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrtho.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrtho.Name = "tabPageOrtho";
            this.tabPageOrtho.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrtho.Size = new System.Drawing.Size(1244, 138);
            this.tabPageOrtho.TabIndex = 0;
            this.tabPageOrtho.Text = "Ortho";
            this.tabPageOrtho.UseVisualStyleBackColor = true;
            // 
            // TrackBarFarOrtho
            // 
            this.TrackBarFarOrtho.Location = new System.Drawing.Point(43, 38);
            this.TrackBarFarOrtho.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarFarOrtho.Maximum = 200;
            this.TrackBarFarOrtho.Minimum = 1;
            this.TrackBarFarOrtho.Name = "TrackBarFarOrtho";
            this.TrackBarFarOrtho.Size = new System.Drawing.Size(1193, 56);
            this.TrackBarFarOrtho.TabIndex = 20;
            this.TrackBarFarOrtho.Value = 50;
            this.TrackBarFarOrtho.Scroll += new System.EventHandler(this.TrackBarOrtFar_Scroll);
            // 
            // labelOrtFar
            // 
            this.labelOrtFar.AutoSize = true;
            this.labelOrtFar.Location = new System.Drawing.Point(39, 4);
            this.labelOrtFar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrtFar.Name = "labelOrtFar";
            this.labelOrtFar.Size = new System.Drawing.Size(29, 17);
            this.labelOrtFar.TabIndex = 19;
            this.labelOrtFar.Text = "Far";
            // 
            // tabPagePerspective
            // 
            this.tabPagePerspective.Controls.Add(this.labelPerFar);
            this.tabPagePerspective.Controls.Add(this.TrackBarFarPerspective);
            this.tabPagePerspective.Location = new System.Drawing.Point(4, 25);
            this.tabPagePerspective.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePerspective.Name = "tabPagePerspective";
            this.tabPagePerspective.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePerspective.Size = new System.Drawing.Size(1244, 138);
            this.tabPagePerspective.TabIndex = 1;
            this.tabPagePerspective.Text = "Perspective";
            this.tabPagePerspective.UseVisualStyleBackColor = true;
            // 
            // labelPerFar
            // 
            this.labelPerFar.AutoSize = true;
            this.labelPerFar.Location = new System.Drawing.Point(600, 15);
            this.labelPerFar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerFar.Name = "labelPerFar";
            this.labelPerFar.Size = new System.Drawing.Size(29, 17);
            this.labelPerFar.TabIndex = 23;
            this.labelPerFar.Text = "Far";
            // 
            // TrackBarFarPerspective
            // 
            this.TrackBarFarPerspective.Location = new System.Drawing.Point(27, 52);
            this.TrackBarFarPerspective.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarFarPerspective.Maximum = 200;
            this.TrackBarFarPerspective.Minimum = 1;
            this.TrackBarFarPerspective.Name = "TrackBarFarPerspective";
            this.TrackBarFarPerspective.Size = new System.Drawing.Size(1209, 56);
            this.TrackBarFarPerspective.TabIndex = 22;
            this.TrackBarFarPerspective.Value = 50;
            this.TrackBarFarPerspective.Scroll += new System.EventHandler(this.TrackBarPerFar_Scroll);
            // 
            // tabPageFrustum
            // 
            this.tabPageFrustum.Controls.Add(this.TrackBarFarFrustum);
            this.tabPageFrustum.Controls.Add(this.labelFruFar);
            this.tabPageFrustum.Location = new System.Drawing.Point(4, 25);
            this.tabPageFrustum.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFrustum.Name = "tabPageFrustum";
            this.tabPageFrustum.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageFrustum.Size = new System.Drawing.Size(1244, 138);
            this.tabPageFrustum.TabIndex = 2;
            this.tabPageFrustum.Text = "Frustum";
            this.tabPageFrustum.UseVisualStyleBackColor = true;
            // 
            // TrackBarFarFrustum
            // 
            this.TrackBarFarFrustum.Location = new System.Drawing.Point(8, 50);
            this.TrackBarFarFrustum.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarFarFrustum.Maximum = 200;
            this.TrackBarFarFrustum.Minimum = 1;
            this.TrackBarFarFrustum.Name = "TrackBarFarFrustum";
            this.TrackBarFarFrustum.Size = new System.Drawing.Size(1216, 56);
            this.TrackBarFarFrustum.TabIndex = 24;
            this.TrackBarFarFrustum.Value = 50;
            this.TrackBarFarFrustum.Scroll += new System.EventHandler(this.TrackBarFruFar_Scroll);
            // 
            // labelFruFar
            // 
            this.labelFruFar.AutoSize = true;
            this.labelFruFar.Location = new System.Drawing.Point(8, 17);
            this.labelFruFar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFruFar.Name = "labelFruFar";
            this.labelFruFar.Size = new System.Drawing.Size(29, 17);
            this.labelFruFar.TabIndex = 23;
            this.labelFruFar.Text = "Far";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(824, 756);
            this.labelTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(17, 17);
            this.labelTest.TabIndex = 24;
            this.labelTest.Text = "X";
            // 
            // openFileDialogTextureImage
            // 
            this.openFileDialogTextureImage.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.Live);
            this.groupBox2.Controls.Add(this.TrackBarLightAngle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ComboBoxLightOptionSelect);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TrackBarLightZ);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TrackBarLightY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TrackBarLightX);
            this.groupBox2.Location = new System.Drawing.Point(1197, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(368, 738);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ComboBoxLightColorSpecularSelect);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.ComboBoxLightColorDiffuseSelect);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ComboBoxLightColorAmbientSelect);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(8, 431);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(352, 300);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light color";
            // 
            // ComboBoxLightColorSpecularSelect
            // 
            this.ComboBoxLightColorSpecularSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLightColorSpecularSelect.FormattingEnabled = true;
            this.ComboBoxLightColorSpecularSelect.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue"});
            this.ComboBoxLightColorSpecularSelect.Location = new System.Drawing.Point(8, 146);
            this.ComboBoxLightColorSpecularSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLightColorSpecularSelect.Name = "ComboBoxLightColorSpecularSelect";
            this.ComboBoxLightColorSpecularSelect.Size = new System.Drawing.Size(335, 24);
            this.ComboBoxLightColorSpecularSelect.TabIndex = 14;
            this.ComboBoxLightColorSpecularSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorSpecular_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "SPECULAR";
            // 
            // ComboBoxLightColorDiffuseSelect
            // 
            this.ComboBoxLightColorDiffuseSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLightColorDiffuseSelect.FormattingEnabled = true;
            this.ComboBoxLightColorDiffuseSelect.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue"});
            this.ComboBoxLightColorDiffuseSelect.Location = new System.Drawing.Point(8, 91);
            this.ComboBoxLightColorDiffuseSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLightColorDiffuseSelect.Name = "ComboBoxLightColorDiffuseSelect";
            this.ComboBoxLightColorDiffuseSelect.Size = new System.Drawing.Size(335, 24);
            this.ComboBoxLightColorDiffuseSelect.TabIndex = 12;
            this.ComboBoxLightColorDiffuseSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorDiffuse_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "DIFFUSE";
            // 
            // ComboBoxLightColorAmbientSelect
            // 
            this.ComboBoxLightColorAmbientSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLightColorAmbientSelect.FormattingEnabled = true;
            this.ComboBoxLightColorAmbientSelect.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue"});
            this.ComboBoxLightColorAmbientSelect.Location = new System.Drawing.Point(8, 39);
            this.ComboBoxLightColorAmbientSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLightColorAmbientSelect.Name = "ComboBoxLightColorAmbientSelect";
            this.ComboBoxLightColorAmbientSelect.Size = new System.Drawing.Size(335, 24);
            this.ComboBoxLightColorAmbientSelect.TabIndex = 10;
            this.ComboBoxLightColorAmbientSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorAmbient_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "AMBIENT";
            // 
            // Live
            // 
            this.Live.AutoSize = true;
            this.Live.Location = new System.Drawing.Point(15, 396);
            this.Live.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(108, 17);
            this.Live.TabIndex = 0;
            this.Live.Text = "Live Information";
            // 
            // TrackBarLightAngle
            // 
            this.TrackBarLightAngle.Location = new System.Drawing.Point(43, 337);
            this.TrackBarLightAngle.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarLightAngle.Maximum = 360;
            this.TrackBarLightAngle.Name = "TrackBarLightAngle";
            this.TrackBarLightAngle.Size = new System.Drawing.Size(317, 56);
            this.TrackBarLightAngle.TabIndex = 4;
            this.TrackBarLightAngle.Scroll += new System.EventHandler(this.TrackBarLightA_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 337);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "An";
            // 
            // ComboBoxLightOptionSelect
            // 
            this.ComboBoxLightOptionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLightOptionSelect.FormattingEnabled = true;
            this.ComboBoxLightOptionSelect.Items.AddRange(new object[] {
            "LIGHT0",
            "LIGHT1",
            "LIGHT2",
            "LIGHT3"});
            this.ComboBoxLightOptionSelect.Location = new System.Drawing.Point(8, 129);
            this.ComboBoxLightOptionSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLightOptionSelect.Name = "ComboBoxLightOptionSelect";
            this.ComboBoxLightOptionSelect.Size = new System.Drawing.Size(351, 24);
            this.ComboBoxLightOptionSelect.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Z";
            // 
            // TrackBarLightZ
            // 
            this.TrackBarLightZ.Location = new System.Drawing.Point(35, 278);
            this.TrackBarLightZ.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarLightZ.Maximum = 500;
            this.TrackBarLightZ.Minimum = -500;
            this.TrackBarLightZ.Name = "TrackBarLightZ";
            this.TrackBarLightZ.Size = new System.Drawing.Size(325, 56);
            this.TrackBarLightZ.TabIndex = 3;
            this.TrackBarLightZ.Scroll += new System.EventHandler(this.TrackBarLightZ_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxLight0);
            this.groupBox3.Controls.Add(this.checkBoxLight1);
            this.groupBox3.Controls.Add(this.checkBoxLight2);
            this.groupBox3.Location = new System.Drawing.Point(11, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(349, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // checkBoxLight0
            // 
            this.checkBoxLight0.AutoSize = true;
            this.checkBoxLight0.Checked = true;
            this.checkBoxLight0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLight0.Location = new System.Drawing.Point(8, 23);
            this.checkBoxLight0.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLight0.Name = "checkBoxLight0";
            this.checkBoxLight0.Size = new System.Drawing.Size(84, 21);
            this.checkBoxLight0.TabIndex = 1;
            this.checkBoxLight0.Text = "Option 1";
            this.checkBoxLight0.UseVisualStyleBackColor = true;
            this.checkBoxLight0.CheckedChanged += new System.EventHandler(this.CheckBoxLight0_CheckedChanged);
            // 
            // checkBoxLight1
            // 
            this.checkBoxLight1.AutoSize = true;
            this.checkBoxLight1.Checked = true;
            this.checkBoxLight1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLight1.Location = new System.Drawing.Point(8, 57);
            this.checkBoxLight1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLight1.Name = "checkBoxLight1";
            this.checkBoxLight1.Size = new System.Drawing.Size(84, 21);
            this.checkBoxLight1.TabIndex = 2;
            this.checkBoxLight1.Text = "Option 2";
            this.checkBoxLight1.UseVisualStyleBackColor = true;
            this.checkBoxLight1.CheckedChanged += new System.EventHandler(this.CheckBoxLight1_CheckedChanged);
            // 
            // checkBoxLight2
            // 
            this.checkBoxLight2.AutoSize = true;
            this.checkBoxLight2.Checked = true;
            this.checkBoxLight2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLight2.Location = new System.Drawing.Point(101, 23);
            this.checkBoxLight2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLight2.Name = "checkBoxLight2";
            this.checkBoxLight2.Size = new System.Drawing.Size(84, 21);
            this.checkBoxLight2.TabIndex = 3;
            this.checkBoxLight2.Text = "Option 3";
            this.checkBoxLight2.UseVisualStyleBackColor = true;
            this.checkBoxLight2.CheckedChanged += new System.EventHandler(this.CheckBoxLight2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Y";
            // 
            // TrackBarLightY
            // 
            this.TrackBarLightY.Location = new System.Drawing.Point(33, 220);
            this.TrackBarLightY.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarLightY.Maximum = 500;
            this.TrackBarLightY.Minimum = -500;
            this.TrackBarLightY.Name = "TrackBarLightY";
            this.TrackBarLightY.Size = new System.Drawing.Size(327, 56);
            this.TrackBarLightY.TabIndex = 2;
            this.TrackBarLightY.Scroll += new System.EventHandler(this.TrackBarLightY_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "X";
            // 
            // TrackBarLightX
            // 
            this.TrackBarLightX.Location = new System.Drawing.Point(33, 166);
            this.TrackBarLightX.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarLightX.Maximum = 500;
            this.TrackBarLightX.Minimum = -500;
            this.TrackBarLightX.Name = "TrackBarLightX";
            this.TrackBarLightX.Size = new System.Drawing.Size(327, 56);
            this.TrackBarLightX.TabIndex = 1;
            this.TrackBarLightX.Scroll += new System.EventHandler(this.TrackBarLightX_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 923);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.tabControlCam);
            this.Controls.Add(this.labelZinfo);
            this.Controls.Add(this.labelYinfo);
            this.Controls.Add(this.labelXinfo);
            this.Controls.Add(this.labelAngleInfo);
            this.Controls.Add(this.labelZoomInfo);
            this.Controls.Add(this.TrackBarZoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TrackBarAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrackBarZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TrackBarY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackBarX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxWired);
            this.Controls.Add(this.comboBoxAxis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimpleOpenGlControl);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).EndInit();
            this.tabControlCam.ResumeLayout(false);
            this.tabPageOrtho.ResumeLayout(false);
            this.tabPageOrtho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarOrtho)).EndInit();
            this.tabPagePerspective.ResumeLayout(false);
            this.tabPagePerspective.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarPerspective)).EndInit();
            this.tabPageFrustum.ResumeLayout(false);
            this.tabPageFrustum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFarFrustum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightZ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLightX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl SimpleOpenGlControl;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogASEModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAxis;
        private System.Windows.Forms.CheckBox checkBoxWired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrackBarX;
        private System.Windows.Forms.TrackBar TrackBarY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TrackBarZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBarAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackBarZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelZoomInfo;
        private System.Windows.Forms.Label labelAngleInfo;
        private System.Windows.Forms.Label labelXinfo;
        private System.Windows.Forms.Label labelYinfo;
        private System.Windows.Forms.Label labelZinfo;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.TabControl tabControlCam;
        private System.Windows.Forms.TabPage tabPageOrtho;
        private System.Windows.Forms.TrackBar TrackBarFarOrtho;
        private System.Windows.Forms.Label labelOrtFar;
        private System.Windows.Forms.TabPage tabPagePerspective;
        private System.Windows.Forms.Label labelPerFar;
        private System.Windows.Forms.TrackBar TrackBarFarPerspective;
        private System.Windows.Forms.TabPage tabPageFrustum;
        private System.Windows.Forms.TrackBar TrackBarFarFrustum;
        private System.Windows.Forms.Label labelFruFar;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.OpenFileDialog openFileDialogTextureImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ComboBoxLightColorSpecularSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboBoxLightColorDiffuseSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboBoxLightColorAmbientSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Live;
        private System.Windows.Forms.TrackBar TrackBarLightAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxLightOptionSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar TrackBarLightZ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxLight0;
        private System.Windows.Forms.CheckBox checkBoxLight1;
        private System.Windows.Forms.CheckBox checkBoxLight2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar TrackBarLightY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar TrackBarLightX;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASEModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextureImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

