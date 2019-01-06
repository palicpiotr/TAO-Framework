using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW3
{
    public partial class Form1 : Form
    {
        #region Inner properties

        double a = Consts.AppOptions.X;
        double b = Consts.AppOptions.Y,
               c = Consts.AppOptions.Z,
               d = Consts.AppOptions.ANGLE,
               zoom = Consts.AppOptions.ZOOM;
        int x_axes = 1, y_axes = default, z_axes = default;
        bool Wire = default;

        #endregion

        #region Initialize form and draw

        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)simpleOpenGlControl1.Width / (float)simpleOpenGlControl1.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            axis.SelectedIndex = 0;
            objectStyles.SelectedIndex = 1;
            objectTypes.SelectedIndex = 0;
            timer.Start();
        }

        #endregion

        #region Event handlers

        private void ObjectStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    Wire = true;
                    break;
                case 1:
                    Wire = false;
                    break;
            }
        }

        private void Axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    {
                        x_axes = 1;
                        y_axes = 0;
                        z_axes = 0;
                        break;
                    }
                case 1:
                    {
                        x_axes = 0;
                        y_axes = 1;
                        z_axes = 0;
                        break;
                    }
                case 2:
                    {
                        x_axes = 0;
                        y_axes = 0;
                        z_axes = 1;
                        break;
                    }
            }
        }


        private void TrackX_Scroll(object sender, EventArgs e)
        {
            TrackbarValueChange(a = ((TrackBar)sender).Value / 1000.0, lXD);
        }

        private void TrackY_Scroll(object sender, EventArgs e)
        {
            TrackbarValueChange(b = ((TrackBar)sender).Value / 1000.0, lYD);
        }

        private void TrackZ_Scroll(object sender, EventArgs e)
        {
            TrackbarValueChange(c = ((TrackBar)sender).Value / 1000.0, lZD);
        }

        private void TrackAngle_Scroll(object sender, EventArgs e)
        {
            TrackbarValueChange(d = ((TrackBar)sender).Value, lAD);
        }

        private void TrackZoom_Scroll(object sender, EventArgs e)
        {
            TrackbarValueChange(zoom = ((TrackBar)sender).Value / 1000.0, lZoomD);
        }

        private void TrackbarValueChange(double trb, Label lbl)
        {
            lbl.Text = trb.ToString();
        }

        private void RedrawSurface_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        #endregion

        #region GL control initializer

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(a, b, c);
            Gl.glRotated(d, x_axes, y_axes, z_axes);
            Gl.glScaled(zoom, zoom, zoom);
            switch (objectTypes.SelectedIndex)
            {
                case 0:
                    {
                        DrawSphere();
                        break;
                    }
                case 1:
                    {
                        DrawCylinder();
                        break;

                    }
                case 2:
                    {
                        DrawCube();
                        break;
                    }
                case 3:
                    {
                        DrawCone();
                        break;

                    }
                case 4:
                    {
                        DrawTorus();
                        break;

                    }
                case 5:
                    {
                        DrawDefaultObjectsWithDefaultPropertyValues();
                        break;
                    }

            }
            Gl.glPopMatrix();
            Gl.glFlush();
            simpleOpenGlControl1.Invalidate();
        }

        private void DrawDefaultObjectsWithDefaultPropertyValues()
        {
            if (Wire)
            {
                Glut.glutWireTorus(0.2, 2.2, 32, 32);
                Gl.glTranslated(-5, 0, 0);
                Glut.glutWireCone(2, 3, 32, 32);
                Gl.glTranslated(10, 0, 0);
                Glut.glutWireSphere(2, 16, 16);
            }
            else
            {
                Glut.glutSolidTorus(0.2, 2.2, 32, 32);
                Gl.glTranslated(-5, 0, 0);
                Glut.glutSolidCone(2, 3, 32, 32);
                Gl.glTranslated(10, 0, 0);
                Glut.glutSolidSphere(2, 16, 16);
            }
        }

        private void DrawTorus()
        {
            if (Wire)
                Glut.glutWireTorus(0.2, 2.2, 32, 32);
            else
                Glut.glutSolidTorus(0.2, 2.2, 32, 32);
        }

        private void DrawCone()
        {
            if (Wire)
                Glut.glutWireCone(2, 3, 32, 32);
            else
                Glut.glutSolidCone(2, 3, 32, 32);
        }

        private void DrawCube()
        {
            if (Wire)
                Glut.glutWireCube(2);
            else
                Glut.glutSolidCube(2);
        }

        private void DrawCylinder()
        {
            if (Wire)
                Glut.glutWireCylinder(1, 2, 32, 32);
            else
                Glut.glutSolidCylinder(1, 2, 32, 32);
        }

        private void DrawSphere()
        {
            if (Wire)
                Glut.glutWireSphere(2, 16, 16);
            else
                Glut.glutSolidSphere(2, 16, 16);
        }

        #endregion

    }
}
