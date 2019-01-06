using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW4
{
    public partial class Form1 : Form
    {
        float _global_time = 0;
        private float[,] _camera_date = new float[4, 7];
        private Bang _bang = new Bang(1, 10, 1, 300, 500);
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            SimpleOpenGlControl.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
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
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            PositionComboBox.SelectedIndex = 1;
            ModeComboBox.SelectedIndex = 0;

            _camera_date[0, 0] = -3;
            _camera_date[0, 1] = 0;
            _camera_date[0, 2] = -20;
            _camera_date[0, 3] = 0;
            _camera_date[0, 4] = 1;
            _camera_date[0, 5] = 0;
            _camera_date[0, 6] = 0;

            _camera_date[1, 0] = -3;
            _camera_date[2, 1] = 2;
            _camera_date[1, 2] = -20;
            _camera_date[1, 3] = 30;
            _camera_date[1, 4] = 1;
            _camera_date[1, 5] = 0;
            _camera_date[1, 6] = 0;

            _camera_date[2, 0] = -3;
            _camera_date[2, 1] = 2;
            _camera_date[2, 2] = -20;
            _camera_date[2, 3] = 30;
            _camera_date[2, 4] = 1;
            _camera_date[2, 5] = 1;
            _camera_date[2, 6] = 0;
            UpdateCamera();
            RenderTimer.Start();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            _global_time += (float)RenderTimer.Interval / 1000;
            Draw();
            UpdateCamera();
        }

        private void Draw()
        {
            if (ModeComboBox.SelectedIndex == 0)
                Gl.glClearColor(255, 255, 255, 1);
            else
                Gl.glClearColor(0, 0, 0, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            if (ModeComboBox.SelectedIndex == 0)
                Gl.glColor3d(0, 0, 0);
            else
                Gl.glColor3d(255, 255, 255);
            Gl.glPushMatrix();
            int camera = PositionComboBox.SelectedIndex;
            Gl.glTranslated(_camera_date[camera, 0], _camera_date[camera, 1], _camera_date[camera, 2]);
            Gl.glRotated(_camera_date[camera, 3], _camera_date[camera, 4], _camera_date[camera, 5], _camera_date[camera, 6]);
            Gl.glPushMatrix();
            DrawMatrix(50);
            _bang.Calculate(_global_time);
            Gl.glPopMatrix();
            Gl.glPopMatrix();
            Gl.glFlush();
            SimpleOpenGlControl.Invalidate();
        }

        private void DrawMatrix(int x)
        {
            float quad_size = 1;
            Gl.glBegin(Gl.GL_LINES);
            for (int ax = 0; ax < x + 1; ax++)
            {
                Gl.glVertex3d(quad_size * ax, 0, 0);
                Gl.glVertex3d(quad_size * ax, 0, quad_size * x);
            }
            for (int bx = 0; bx < x + 1; bx++)
            {
                Gl.glVertex3d(0, 0, quad_size * bx);
                Gl.glVertex3d(quad_size * x, 0, quad_size * bx);
            }
            Gl.glEnd();
        }

        private void BangLast_Click(object sender, EventArgs e)
        {
            _bang.SetNewPosition(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 5));
            _bang.SetNewPower(rnd.Next(20, 80));
            _bang.BoooomForward(_global_time);
        }

        private void UpdateCamera()
        {

            _camera_date[3, 0] = TrackBarX.Value;
            _camera_date[3, 1] = TrackBarY.Value;
            _camera_date[3, 2] = TrackBarZ.Value;
            _camera_date[3, 3] = TrackBarDeg.Value;
            _camera_date[3, 4] = (TrackByX.Checked) ? 1 : 0;
            _camera_date[3, 5] = (TrackByY.Checked) ? 1 : 0;
            _camera_date[3, 6] = (TrackByZ.Checked) ? 1 : 0;
            label3.Text = $"x {_camera_date[3, 0]} \n y {_camera_date[3, 1]} \n z {_camera_date[3, 2]} \n deg {_camera_date[3, 3]}"; ;
        }

        private void BangButton_Click(object sender, EventArgs e)
        {
            _bang.SetNewPosition(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 5));
            _bang.SetNewPower(rnd.Next(20, 80));
            _bang.Boooom(_global_time);
        }
    }
}
