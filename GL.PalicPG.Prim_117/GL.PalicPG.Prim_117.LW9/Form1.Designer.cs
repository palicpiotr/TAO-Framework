namespace GL.PalicPG.Prim_117.LW9
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openASEModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextureImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialogASEModel = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAxis = new System.Windows.Forms.ComboBox();
            this.checkBoxWired = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelZoomInfo = new System.Windows.Forms.Label();
            this.labelAngleInfo = new System.Windows.Forms.Label();
            this.labelXinfo = new System.Windows.Forms.Label();
            this.labelYinfo = new System.Windows.Forms.Label();
            this.labelZinfo = new System.Windows.Forms.Label();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControlCam = new System.Windows.Forms.TabControl();
            this.tabPageOrtho = new System.Windows.Forms.TabPage();
            this.trackBarOrtFar = new System.Windows.Forms.TrackBar();
            this.labelOrtFar = new System.Windows.Forms.Label();
            this.tabPagePerspective = new System.Windows.Forms.TabPage();
            this.labelPerFar = new System.Windows.Forms.Label();
            this.trackBarPerFar = new System.Windows.Forms.TrackBar();
            this.tabPageFrustum = new System.Windows.Forms.TabPage();
            this.trackBarFruFar = new System.Windows.Forms.TrackBar();
            this.labelFruFar = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.openFileDialogTextureImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.СomboBoxLightColorSpecular = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.СomboBoxLightColorDiffuse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.СomboBoxLightColorAmbient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLightInfo = new System.Windows.Forms.Label();
            this.trackBarLightA = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxLights = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarLightZ = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxLight0 = new System.Windows.Forms.CheckBox();
            this.checkBoxLight1 = new System.Windows.Forms.CheckBox();
            this.checkBoxLight2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarLightY = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarLightX = new System.Windows.Forms.TrackBar();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.tabControlCam.SuspendLayout();
            this.tabPageOrtho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOrtFar)).BeginInit();
            this.tabPagePerspective.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPerFar)).BeginInit();
            this.tabPageFrustum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFruFar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightZ)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightX)).BeginInit();
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
            this.AnT.Location = new System.Drawing.Point(16, 33);
            this.AnT.Margin = new System.Windows.Forms.Padding(4);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(800, 738);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
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
            this.toolStripSeparator1});
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
            // openFileDialogASEModel
            // 
            this.openFileDialogASEModel.FileName = "openFileDialog1";
            this.openFileDialogASEModel.Filter = "ASE files (*.ase)|*.ase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 65);
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
            "byX",
            "byY",
            "byZ"});
            this.comboBoxAxis.Location = new System.Drawing.Point(824, 85);
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
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(824, 187);
            this.trackBarX.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarX.Maximum = 50000;
            this.trackBarX.Minimum = -50000;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarX.Size = new System.Drawing.Size(56, 518);
            this.trackBarX.TabIndex = 7;
            this.trackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(892, 187);
            this.trackBarY.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarY.Maximum = 50000;
            this.trackBarY.Minimum = -50000;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.Size = new System.Drawing.Size(56, 518);
            this.trackBarY.TabIndex = 9;
            this.trackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
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
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(975, 187);
            this.trackBarZ.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarZ.Maximum = 50000;
            this.trackBarZ.Minimum = -50000;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZ.Size = new System.Drawing.Size(56, 518);
            this.trackBarZ.TabIndex = 11;
            this.trackBarZ.Scroll += new System.EventHandler(this.TrackBarZ_Scroll);
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
            // trackBarAngle
            // 
            this.trackBarAngle.Location = new System.Drawing.Point(1059, 187);
            this.trackBarAngle.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarAngle.Maximum = 360;
            this.trackBarAngle.Minimum = -360;
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAngle.Size = new System.Drawing.Size(56, 518);
            this.trackBarAngle.TabIndex = 13;
            this.trackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
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
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(1127, 187);
            this.trackBarZoom.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarZoom.Maximum = 5000;
            this.trackBarZoom.Minimum = -5000;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZoom.Size = new System.Drawing.Size(56, 518);
            this.trackBarZoom.TabIndex = 15;
            this.trackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoom_Scroll);
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
            this.tabPageOrtho.Controls.Add(this.trackBarOrtFar);
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
            // trackBarOrtFar
            // 
            this.trackBarOrtFar.Location = new System.Drawing.Point(43, 38);
            this.trackBarOrtFar.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarOrtFar.Maximum = 200;
            this.trackBarOrtFar.Minimum = 1;
            this.trackBarOrtFar.Name = "trackBarOrtFar";
            this.trackBarOrtFar.Size = new System.Drawing.Size(1167, 56);
            this.trackBarOrtFar.TabIndex = 20;
            this.trackBarOrtFar.Value = 50;
            this.trackBarOrtFar.Scroll += new System.EventHandler(this.TrackBarOrtFar_Scroll);
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
            this.tabPagePerspective.Controls.Add(this.trackBarPerFar);
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
            // trackBarPerFar
            // 
            this.trackBarPerFar.Location = new System.Drawing.Point(8, 50);
            this.trackBarPerFar.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPerFar.Maximum = 200;
            this.trackBarPerFar.Minimum = 1;
            this.trackBarPerFar.Name = "trackBarPerFar";
            this.trackBarPerFar.Size = new System.Drawing.Size(1208, 56);
            this.trackBarPerFar.TabIndex = 22;
            this.trackBarPerFar.Value = 50;
            this.trackBarPerFar.Scroll += new System.EventHandler(this.TrackBarPerFar_Scroll);
            // 
            // tabPageFrustum
            // 
            this.tabPageFrustum.Controls.Add(this.trackBarFruFar);
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
            // trackBarFruFar
            // 
            this.trackBarFruFar.Location = new System.Drawing.Point(8, 50);
            this.trackBarFruFar.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarFruFar.Maximum = 200;
            this.trackBarFruFar.Minimum = 1;
            this.trackBarFruFar.Name = "trackBarFruFar";
            this.trackBarFruFar.Size = new System.Drawing.Size(1202, 56);
            this.trackBarFruFar.TabIndex = 24;
            this.trackBarFruFar.Value = 50;
            this.trackBarFruFar.Scroll += new System.EventHandler(this.TrackBarFruFar_Scroll);
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
            this.groupBox2.Controls.Add(this.labelLightInfo);
            this.groupBox2.Controls.Add(this.trackBarLightA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxLights);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.trackBarLightZ);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.trackBarLightY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackBarLightX);
            this.groupBox2.Location = new System.Drawing.Point(1197, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(368, 738);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.СomboBoxLightColorSpecular);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.СomboBoxLightColorDiffuse);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.СomboBoxLightColorAmbient);
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
            // СomboBoxLightColorSpecular
            // 
            this.СomboBoxLightColorSpecular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxLightColorSpecular.FormattingEnabled = true;
            this.СomboBoxLightColorSpecular.Items.AddRange(new object[] {
            "Black",
            "White",
            "Green",
            "Blue"});
            this.СomboBoxLightColorSpecular.Location = new System.Drawing.Point(8, 146);
            this.СomboBoxLightColorSpecular.Margin = new System.Windows.Forms.Padding(4);
            this.СomboBoxLightColorSpecular.Name = "СomboBoxLightColorSpecular";
            this.СomboBoxLightColorSpecular.Size = new System.Drawing.Size(335, 24);
            this.СomboBoxLightColorSpecular.TabIndex = 14;
            this.СomboBoxLightColorSpecular.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorSpecular_SelectedIndexChanged);
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
            // СomboBoxLightColorDiffuse
            // 
            this.СomboBoxLightColorDiffuse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxLightColorDiffuse.FormattingEnabled = true;
            this.СomboBoxLightColorDiffuse.Items.AddRange(new object[] {
            "Black",
            "White",
            "Green",
            "Blue"});
            this.СomboBoxLightColorDiffuse.Location = new System.Drawing.Point(8, 91);
            this.СomboBoxLightColorDiffuse.Margin = new System.Windows.Forms.Padding(4);
            this.СomboBoxLightColorDiffuse.Name = "СomboBoxLightColorDiffuse";
            this.СomboBoxLightColorDiffuse.Size = new System.Drawing.Size(335, 24);
            this.СomboBoxLightColorDiffuse.TabIndex = 12;
            this.СomboBoxLightColorDiffuse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorDiffuse_SelectedIndexChanged);
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
            // СomboBoxLightColorAmbient
            // 
            this.СomboBoxLightColorAmbient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxLightColorAmbient.FormattingEnabled = true;
            this.СomboBoxLightColorAmbient.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue"});
            this.СomboBoxLightColorAmbient.Location = new System.Drawing.Point(8, 39);
            this.СomboBoxLightColorAmbient.Margin = new System.Windows.Forms.Padding(4);
            this.СomboBoxLightColorAmbient.Name = "СomboBoxLightColorAmbient";
            this.СomboBoxLightColorAmbient.Size = new System.Drawing.Size(335, 24);
            this.СomboBoxLightColorAmbient.TabIndex = 10;
            this.СomboBoxLightColorAmbient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLightColorAmbient_SelectedIndexChanged);
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
            // labelLightInfo
            // 
            this.labelLightInfo.AutoSize = true;
            this.labelLightInfo.Location = new System.Drawing.Point(15, 396);
            this.labelLightInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLightInfo.Name = "labelLightInfo";
            this.labelLightInfo.Size = new System.Drawing.Size(92, 17);
            this.labelLightInfo.TabIndex = 0;
            this.labelLightInfo.Text = "labelLightInfo";
            // 
            // trackBarLightA
            // 
            this.trackBarLightA.Location = new System.Drawing.Point(43, 337);
            this.trackBarLightA.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLightA.Maximum = 360;
            this.trackBarLightA.Name = "trackBarLightA";
            this.trackBarLightA.Size = new System.Drawing.Size(317, 56);
            this.trackBarLightA.TabIndex = 4;
            this.trackBarLightA.Scroll += new System.EventHandler(this.TrackBarLightA_Scroll);
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
            // comboBoxLights
            // 
            this.comboBoxLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLights.FormattingEnabled = true;
            this.comboBoxLights.Items.AddRange(new object[] {
            "LIGHT0",
            "LIGHT1",
            "LIGHT2",
            "LIGHT3"});
            this.comboBoxLights.Location = new System.Drawing.Point(8, 129);
            this.comboBoxLights.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLights.Name = "comboBoxLights";
            this.comboBoxLights.Size = new System.Drawing.Size(351, 24);
            this.comboBoxLights.TabIndex = 6;
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
            // trackBarLightZ
            // 
            this.trackBarLightZ.Location = new System.Drawing.Point(35, 278);
            this.trackBarLightZ.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLightZ.Maximum = 500;
            this.trackBarLightZ.Minimum = -500;
            this.trackBarLightZ.Name = "trackBarLightZ";
            this.trackBarLightZ.Size = new System.Drawing.Size(325, 56);
            this.trackBarLightZ.TabIndex = 3;
            this.trackBarLightZ.Scroll += new System.EventHandler(this.TrackBarLightZ_Scroll);
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
            this.groupBox3.Text = "Enable";
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
            this.checkBoxLight0.Text = "Option 0";
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
            this.checkBoxLight1.Text = "Option 1";
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
            this.checkBoxLight2.Text = "Option 2";
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
            // trackBarLightY
            // 
            this.trackBarLightY.Location = new System.Drawing.Point(33, 220);
            this.trackBarLightY.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLightY.Maximum = 500;
            this.trackBarLightY.Minimum = -500;
            this.trackBarLightY.Name = "trackBarLightY";
            this.trackBarLightY.Size = new System.Drawing.Size(327, 56);
            this.trackBarLightY.TabIndex = 2;
            this.trackBarLightY.Scroll += new System.EventHandler(this.TrackBarLightY_Scroll);
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
            // trackBarLightX
            // 
            this.trackBarLightX.Location = new System.Drawing.Point(33, 166);
            this.trackBarLightX.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLightX.Maximum = 500;
            this.trackBarLightX.Minimum = -500;
            this.trackBarLightX.Name = "trackBarLightX";
            this.trackBarLightX.Size = new System.Drawing.Size(327, 56);
            this.trackBarLightX.TabIndex = 1;
            this.trackBarLightX.Scroll += new System.EventHandler(this.TrackBarLightX_Scroll);
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
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxWired);
            this.Controls.Add(this.comboBoxAxis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.tabControlCam.ResumeLayout(false);
            this.tabPageOrtho.ResumeLayout(false);
            this.tabPageOrtho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOrtFar)).EndInit();
            this.tabPagePerspective.ResumeLayout(false);
            this.tabPagePerspective.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPerFar)).EndInit();
            this.tabPageFrustum.ResumeLayout(false);
            this.tabPageFrustum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFruFar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightZ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLightX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogASEModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAxis;
        private System.Windows.Forms.CheckBox checkBoxWired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelZoomInfo;
        private System.Windows.Forms.Label labelAngleInfo;
        private System.Windows.Forms.Label labelXinfo;
        private System.Windows.Forms.Label labelYinfo;
        private System.Windows.Forms.Label labelZinfo;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.TabControl tabControlCam;
        private System.Windows.Forms.TabPage tabPageOrtho;
        private System.Windows.Forms.TrackBar trackBarOrtFar;
        private System.Windows.Forms.Label labelOrtFar;
        private System.Windows.Forms.TabPage tabPagePerspective;
        private System.Windows.Forms.Label labelPerFar;
        private System.Windows.Forms.TrackBar trackBarPerFar;
        private System.Windows.Forms.TabPage tabPageFrustum;
        private System.Windows.Forms.TrackBar trackBarFruFar;
        private System.Windows.Forms.Label labelFruFar;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.OpenFileDialog openFileDialogTextureImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox СomboBoxLightColorSpecular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox СomboBoxLightColorDiffuse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox СomboBoxLightColorAmbient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLightInfo;
        private System.Windows.Forms.TrackBar trackBarLightA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxLights;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarLightZ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxLight0;
        private System.Windows.Forms.CheckBox checkBoxLight1;
        private System.Windows.Forms.CheckBox checkBoxLight2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarLightY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarLightX;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASEModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextureImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

