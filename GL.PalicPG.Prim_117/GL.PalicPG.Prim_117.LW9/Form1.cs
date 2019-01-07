using System;
using System.Drawing;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW9
{
    public partial class Form1 : Form
    {
        const int VALUE_X = 0, VALUE_Y = 0, VALUE_Z = -5, VALUE_ANGLE = 0, VALUE_ZOOM = 1;
        double a = 0;
        double b = 0, c = -5, d = 90, zoom = 1;
        int os_x = 1, os_y = 0, os_z = 0;
        int aniEarchRot = 0;
        uint mainTextureID = 0;
        bool isTextureAvalible = false;
        float[] colorBlack = { 0.0f, 0.0f, 0.0f, 1.0f };
        float[] colorWhite = { 1.0f, 1.0f, 1.0f, 1.0f };
        float[] colorRed = { 1.0f, 0.0f, 0.0f, 1.0f };
        float[] colorGreen = { 0.0f, 1.0f, 0.0f, 1.0f };
        float[] colorBlue = { 0.0f, 0.0f, 1.0f, 1.0f };
        bool Wire = false;
        ModelLoader Model = null;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void OpenASEModelToolStripMenuItem_Click(object sender, EventArgs e) => OpenFileASE();

        private void OpenTextureImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogTextureImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap img = new Bitmap(openFileDialogTextureImage.FileName);
                    byte[] imgArr = new byte[img.Height * img.Width * 4];
                    for (int i = 0; i < img.Height; i++)
                    {
                        for (int j = 0; j < img.Width; j++)
                        {
                            Color pixel = img.GetPixel(i, j);
                            imgArr[i * img.Width + j + 0] = pixel.R;
                            imgArr[i * img.Width + j + 1] = pixel.G;
                            imgArr[i * img.Width + j + 2] = pixel.B;
                            imgArr[i * img.Width + j + 3] = pixel.A;
                        }
                    }
                    Gl.glGenTextures(1, out mainTextureID);
                    Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 1);
                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, mainTextureID);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_R, Gl.GL_REPEAT);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
                    Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_MODULATE);
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, img.Width, img.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, imgArr);
                    isTextureAvalible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message + " " + ex.StackTrace);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e) => OpenFileASE();

        private void OpenFileASE()
        {
            if (openFileDialogASEModel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Model = new ModelLoader();
                    Model.LoadModel(openFileDialogASEModel.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            float[] pos = { 0f, 0.0f, 0f, 1.0f };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, pos);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, colorWhite);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, colorRed);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, colorBlue);
            Gl.glEnable(Gl.GL_LIGHT1);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, pos);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_AMBIENT, colorBlack);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, colorGreen);
            Gl.glEnable(Gl.GL_LIGHT2);
            float[] dirVector = { 0.0f, 0.0f, -1.0f };
            Gl.glLightfv(Gl.GL_LIGHT2, Gl.GL_POSITION, pos);
            Gl.glLightfv(Gl.GL_LIGHT2, Gl.GL_DIFFUSE, colorWhite);
            Gl.glLightfv(Gl.GL_LIGHT2, Gl.GL_SPOT_DIRECTION, dirVector);
            Gl.glLightf(Gl.GL_LIGHT2, Gl.GL_SPOT_CUTOFF, 10.0f);
            float[] globalAmbient = { 0.0f, 0.0f, 0.3f, 1.0f };
            Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, globalAmbient);
            comboBoxAxis.SelectedIndex = 0;
            comboBoxLights.SelectedIndex = 0;
            renderTimer.Start();
            a = trackBarX.Value / 1000.0;
            b = trackBarY.Value / 1000.0;
            c = trackBarZ.Value / 1000.0;
            d = trackBarAngle.Value;
            zoom = trackBarZoom.Value / 100.0;
        }

        private void CheckBoxWired_CheckedChanged(object sender, EventArgs e)
        {
            Wire = ((CheckBox)sender).Checked;
        }

        private void TabControlCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            labelTest.Text = tc.SelectedTab.Text;

            switch (tc.SelectedIndex)
            {
                case 0:
                    ChangeOrt();
                    break;
                case 1:
                    ChangePer();
                    break;
                case 2:
                    ChangeFru();
                    break;
            }
        }

        private void TrackBarPerAngle_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelPerAngle.Text = "Angle " + tb.Value;
            ChangePer();
        }

        private void TrackBarPerFar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelPerFar.Text = "Far " + tb.Value;
            ChangePer();
        }

        private void TrackBarOrtFar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelOrtFar.Text = "Far " + tb.Value;
            ChangeOrt();
        }

        private void TrackBarFruFar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelFruFar.Text = "Far " + tb.Value;
            ChangeFru();
        }

        private void ChangeOrt()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-1.0, 1.0, -1.0, 1.0, 0, trackBarOrtFar.Value);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void ChangePer()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(trackBarPerAngle.Value, (float)AnT.Width / (float)AnT.Height, 0.1, trackBarPerFar.Value);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void ChangeFru()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-0.01, 0.1, -0.01, 0.1, 0.1, trackBarFruFar.Value);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void ComboBoxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    {
                        os_x = 1;
                        os_y = 0;
                        os_z = 0;
                        break;
                    }
                case 1:
                    {
                        os_x = 0;
                        os_y = 1;
                        os_z = 0;
                        break;
                    }
                case 2:
                    {
                        os_x = 0;
                        os_y = 0;
                        os_z = 1;
                        break;
                    }
            }
        }

        private void TrackBarLightX_Scroll(object sender, EventArgs e) => ChangeLightParams();

        private void TrackBarLightZ_Scroll(object sender, EventArgs e) => ChangeLightParams();

        private void TrackBarLightY_Scroll(object sender, EventArgs e) => ChangeLightParams();

        private void TrackBarLightA_Scroll(object sender, EventArgs e) => ChangeLightParams();

        private void ChangeLightParams()
        {
            labelLightInfo.Text = $"X {trackBarLightX.Value} Y {trackBarLightY.Value} Z{trackBarLightZ.Value} Angle {trackBarLightA.Value}";
            int LIGHT = Gl.GL_LIGHT0;
            switch (comboBoxLights.SelectedIndex)
            {
                case 0:
                    LIGHT = Gl.GL_LIGHT0;
                    break;
                case 1:
                    LIGHT = Gl.GL_LIGHT1;
                    break;
                case 2:
                    LIGHT = Gl.GL_LIGHT2;
                    break;
                case 3:
                    LIGHT = Gl.GL_LIGHT3;
                    break;
            }
            float[] pos = { trackBarLightX.Value / 20f, trackBarLightY.Value / 20f, trackBarLightZ.Value / 20f, 1.0f };
            Gl.glLightfv(LIGHT, Gl.GL_POSITION, pos);
        }

        private void CheckBoxLight0_CheckedChanged(object sender, EventArgs e) => LightSwitcher(((CheckBox)sender).Checked, Gl.GL_LIGHT0);

        private void CheckBoxLight1_CheckedChanged(object sender, EventArgs e) => LightSwitcher(((CheckBox)sender).Checked, Gl.GL_LIGHT1);

        private void CheckBoxLight2_CheckedChanged(object sender, EventArgs e) => LightSwitcher(((CheckBox)sender).Checked, Gl.GL_LIGHT2);

        private void ComboBoxLightColorAmbient_SelectedIndexChanged(object sender, EventArgs e) => LightColorSwitcher(comboBoxLights.SelectedIndex, Gl.GL_AMBIENT, comboBoxLightColorAmbient.SelectedIndex);

        private void ComboBoxLightColorDiffuse_SelectedIndexChanged(object sender, EventArgs e) => LightColorSwitcher(comboBoxLights.SelectedIndex, Gl.GL_DIFFUSE, comboBoxLightColorDiffuse.SelectedIndex);

        private void ComboBoxLightColorSpecular_SelectedIndexChanged(object sender, EventArgs e) => LightColorSwitcher(comboBoxLights.SelectedIndex, Gl.GL_SPECULAR, comboBoxLightColorSpecular.SelectedIndex);

        private void LightColorSwitcher(int light, int PNAME, int color)
        {
            float[] c = colorBlack;
            int l = Gl.GL_LIGHT0;

            switch (color)
            {
                case 0:
                    c = colorBlack;
                    break;
                case 1:
                    c = colorWhite;
                    break;
                case 2:
                    c = colorRed;
                    break;
                case 3:
                    c = colorGreen;
                    break;
                case 4:
                    c = colorBlue;
                    break;
            }

            switch (light)
            {
                case 0:
                    l = Gl.GL_LIGHT0;
                    break;
                case 1:
                    l = Gl.GL_LIGHT1;
                    break;
                case 2:
                    l = Gl.GL_LIGHT2;
                    break;
                case 3:
                    l = Gl.GL_LIGHT3;
                    break;
            }

            Gl.glLightfv(l, PNAME, c);
        }


        private void LightSwitcher(bool enable, int LIGHT)
        {
            if (enable)
                Gl.glEnable(LIGHT);
            else
                Gl.glDisable(LIGHT);
        }

        private void TrackBarX_Scroll(object sender, EventArgs e) => TrackbarValueChange(a = ((TrackBar)sender).Value / 1000.0, labelXinfo);

        private void TrackBarY_Scroll(object sender, EventArgs e) => TrackbarValueChange(b = ((TrackBar)sender).Value / 1000.0, labelYinfo);

        private void TrackBarZ_Scroll(object sender, EventArgs e) => TrackbarValueChange(c = ((TrackBar)sender).Value / 1000.0, labelZinfo);

        private void TrackBarAngle_Scroll(object sender, EventArgs e) => TrackbarValueChange(d = ((TrackBar)sender).Value, labelAngleInfo);

        private void TrackBarZoom_Scroll(object sender, EventArgs e) => TrackbarValueChange(zoom = ((TrackBar)sender).Value / 1000.0, labelZoomInfo);

        private void TrackbarValueChange(double trb, Label lbl) => lbl.Text = trb.ToString();

        private void RenderTimer_Tick(object sender, EventArgs e) => Draw();

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0.1f, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(a, b, c);
            Gl.glRotated(d, os_x, os_y, os_z);
            Gl.glRotated(aniEarchRot, 0.7, 0.2, 0.1);
            aniEarchRot++;
            Gl.glScaled(zoom, zoom, zoom);
            if (Model != null)
                Model.DrawModel();
            Gl.glPopMatrix();
            Gl.glPushMatrix();
            Gl.glTranslated(a + (Math.Cos(aniEarchRot / 20.0)) * 3, b + (Math.Sin(aniEarchRot / 20.0)) * 3, c + (Math.Sin(aniEarchRot / 40.0)) * 3);
            Glut.glutSolidSphere(0.3, 20, 20);
            Gl.glPopMatrix();
            if (isTextureAvalible)
            {
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                Gl.glPushMatrix();
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mainTextureID);
                Gl.glBegin(Gl.GL_QUADS);
                int z = -3;
                Gl.glVertex3d(-10, -3, z);
                Gl.glTexCoord2f(0, 0);
                Gl.glVertex3d(10, -3, z);
                Gl.glTexCoord2f(1, 0);
                Gl.glVertex3d(10, 17, z);
                Gl.glTexCoord2f(1, 1);
                Gl.glVertex3d(-10, 17, z);
                Gl.glTexCoord2f(0, 1);
                Gl.glDisable(Gl.GL_TEXTURE_2D);
                Gl.glEnd();
                Gl.glPopMatrix();
                Gl.glDisable(Gl.GL_TEXTURE_2D);
            }
            Gl.glFlush();
            AnT.Invalidate();
        }
    }
}
