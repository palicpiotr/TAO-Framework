﻿using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW6
{
    public partial class Form1 : Form
    {
        const int VALUE_X = 0, VALUE_Y = 0, VALUE_Z = -5, VALUE_ANGLE = 0, VALUE_ZOOM = 1;
        double a = VALUE_X;
        double b = VALUE_Y, c = VALUE_Z, d = VALUE_ANGLE, zoom = VALUE_ZOOM;
        int os_x = 1, os_y = 0, os_z = 0;
        bool Wire = false;
        ModelLoader Model = null;

        private void OpenASEModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Model = new ModelLoader();
                    Model.LoadModel(OpenFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void TrackBarX_Scroll(object sender, EventArgs e) => TrackbarValueChange(a = ((TrackBar)sender).Value / 1000.0, LabelX);

        private void TrackbarValueChange(double trb, Label lbl) => lbl.Text = trb.ToString();

        private void TrackBarY_Scroll(object sender, EventArgs e) => TrackbarValueChange(b = ((TrackBar)sender).Value / 1000.0, LableY);

        private void TrackBarZ_Scroll(object sender, EventArgs e) => TrackbarValueChange(c = ((TrackBar)sender).Value / 1000.0, LabelZ);

        private void TrackBarAngle_Scroll(object sender, EventArgs e) => TrackbarValueChange(d = ((TrackBar)sender).Value, LabelAngle);

        private void TrackBarZoom_Scroll(object sender, EventArgs e) => TrackbarValueChange(zoom = ((TrackBar)sender).Value / 1000.0, LabelZoom);

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, SimpleOpenGlControl.Width, SimpleOpenGlControl.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)SimpleOpenGlControl.Width / (float)SimpleOpenGlControl.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            AxisComboBox.SelectedIndex = 0;
            RenderTimer.Start();
        }

        private void RenderTimer_Tick(object sender, EventArgs e) => Draw();

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(a, b, c);
            Gl.glRotated(d, os_x, os_y, os_z);
            Gl.glScaled(zoom, zoom, zoom);
            if (Model != null)
                Model.DrawModel();
            Gl.glPopMatrix();
            Gl.glFlush();
            SimpleOpenGlControl.Invalidate();

        }

        private void X(object sender, EventArgs e)
        { }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => Wire = ((CheckBox)sender).Checked;

        public Form1()
        {
            InitializeComponent();
            SimpleOpenGlControl.InitializeContexts();
        }

        private void AxisComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
