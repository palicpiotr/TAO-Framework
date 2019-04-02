using Course.Building.Palic.CameraOptions;
using Course.Building.Palic.Enums;
using Course.Building.Palic.Models;
using Course.Building.Palic.TextureOptions;
using System;
using System.Windows.Forms;
using Tao.DevIl;
using Tao.FreeGlut;
using Tao.OpenGl;
using Point = Course.Building.Palic.Models.Point;

namespace Course.Building.Palic
{
    public partial class Form1 : Form
    {
        private Camera _camera;
        private Texture _floorTexture;
        private Texture _boxTexture;
        private Texture _logTexture;
        private Texture _shelfTexture;
        private Texture _teapotTexture;
        private Point _blockCoord = new Point(2, 3, 2);
        private Point _logCoord = new Point(3, 5, 6);
        private bool isBoomed = false;
        private float _globalTime = 0;
        private float _localTime = 0;
        private Explosion _boom = new Explosion(1, -20, 1, 350, 450);
        private int _boxAngle = 0;
        private const int _angleStep = 90;
        private const int _transferStep = -10;
        private float _logZoom = 1;
        private bool _randomAnimationUsed = false;

        public Form1()
        {
            InitializeComponent();
            DrawWindow.InitializeContexts();
            _camera = new Camera
            {
                Position = new Point(0, 0, -15),
                Incline = new Point(0, 0, 0)
            };
            MouseWheel += OnMouseWheel;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, DrawWindow.Width, DrawWindow.Height);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            _floorTexture = new Texture("Textures\\Floor.jpg");
            _boxTexture = new Texture("Textures\\Block.jpg");
            _logTexture = new Texture("Textures\\Log.jpg");
            _shelfTexture = new Texture("Textures\\Sh.jpg");
            _teapotTexture = new Texture("Textures\\Teapot.jpg");
            timer.Start();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                _camera.Position = new Point(_camera.Position.X, _camera.Position.Y - 1, _camera.Position.Z);
            if (e.KeyCode == Keys.S)
                _camera.Position = new Point(_camera.Position.X, _camera.Position.Y + 1, _camera.Position.Z);
            if (e.KeyCode == Keys.A)
                _camera.Position = new Point(_camera.Position.X + 1, _camera.Position.Y, _camera.Position.Z);
            if (e.KeyCode == Keys.D)
                _camera.Position = new Point(_camera.Position.X - 1, _camera.Position.Y, _camera.Position.Z);
            if (e.KeyCode == Keys.W)
                _camera.Position = new Point(_camera.Position.X, _camera.Position.Y - 1, _camera.Position.Z);
            if (e.KeyCode == Keys.X)
                _camera.Incline = new Point(_camera.Incline.X + 1, _camera.Incline.Y, _camera.Incline.Z);
            if (e.KeyCode == Keys.C)
                _camera.Incline = new Point(_camera.Incline.X - 1, _camera.Incline.Y, _camera.Incline.Z);
            if (e.KeyCode == Keys.Q)
                _camera.Incline = new Point(_camera.Incline.X, _camera.Incline.Y, _camera.Incline.Z + 1);
            if (e.KeyCode == Keys.E)
                _camera.Incline = new Point(_camera.Incline.X, _camera.Incline.Y, _camera.Incline.Z - 1);
            if (e.KeyCode == Keys.B)
            {
                isBoomed = true;
                ChangeExplosion(_globalTime);
            }
            if (e.KeyCode == Keys.P)
            {
                _blockCoord = new Point(_blockCoord.X, _blockCoord.Y, _blockCoord.Z + _transferStep);
            }
            if (e.KeyCode == Keys.M)
            {
                _logZoom *= 2.5f;
            }
            if (e.KeyCode == Keys.N)
            {
                _logZoom /= 2.5f;
            }
            if (e.KeyCode == Keys.L)
                _blockCoord = new Point(_blockCoord.X + 1, _blockCoord.Y, _blockCoord.Z);
            if (e.KeyCode == Keys.J)
                _blockCoord = new Point(_blockCoord.X - 1, _blockCoord.Y, _blockCoord.Z);
            if (e.KeyCode == Keys.I)
                _blockCoord = new Point(_blockCoord.X, _blockCoord.Y + 1, _blockCoord.Z);
            if (e.KeyCode == Keys.K)
                _blockCoord = new Point(_blockCoord.X, _blockCoord.Y - 1, _blockCoord.Z);
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                _camera.Position = new Point(_camera.Position.X, _camera.Position.Y, _camera.Position.Z + 1);
            if (e.Delta < 0)
                _camera.Position = new Point(_camera.Position.X, _camera.Position.Y, _camera.Position.Z - 1);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _globalTime += (float)timer.Interval / 1000;
            _camera.SetCamera(Projection.Perspective);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            if (_randomAnimationUsed && (_globalTime - _localTime) > 1)
            {
                _localTime = _globalTime;

                if (_boxAngle + _angleStep < 0)
                    _boxAngle += 360;
                _boxAngle += _angleStep;

                _blockCoord = new Point(_blockCoord.X, _blockCoord.Y + _transferStep, _blockCoord.Z);

                Random rnd = new Random();
                if (rnd.NextDouble() > 0.5)
                    _logZoom *= 1.5f;
                else
                    _logZoom /= 1.5f;
            }

            DrawFloor();
            DrawRack();
            if (!isBoomed)
                DrawBlock(_blockCoord.X, _blockCoord.Y, 0);
            DrawBlock(_blockCoord.X + 3, _blockCoord.Y + 3, _blockCoord.Z);
            DrawBlock(_blockCoord.X + 6, _blockCoord.Y + 6, _blockCoord.Z + 3);
            DrawBoom(_globalTime);
            DrawLog();
            DrawTeapot();
            DrawWindow.Invalidate();
        }

        #region Draw

        public void DrawLog()
        {
            Gl.glClearColor(255, 255, 255, 1);

            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_S);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_T);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, _logTexture.mGlTextureObject);

            Gl.glPushMatrix();

            Gl.glTranslated(_logCoord.X, _logCoord.Y - 3, 0);

            Glut.glutSolidCylinder(0.5 * _logZoom, 4, 50, 50);

            Gl.glDisable(Gl.GL_TEXTURE_GEN_S);
            Gl.glDisable(Gl.GL_TEXTURE_GEN_T);

            Gl.glPopMatrix();

            Gl.glFlush();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        public void DrawBoom(float global_time)
        {
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glRotated(90, 1, 0, 0);
            Gl.glPushMatrix();
            Calculate(CalculateExplosionCoordinates(), global_time);
            Gl.glPopMatrix();
            Gl.glFlush();
        }

        public void DrawBlock(double x, double y, double z)
        {
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_S);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_T);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, _boxTexture.mGlTextureObject);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(x, y, z);
            Gl.glRotated(_boxAngle, 0, 0, 1);
            Glut.glutSolidCube(4);
            Gl.glPopMatrix();
            Gl.glFlush();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        public void DrawTeapot()
        {
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_S);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_T);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, _teapotTexture.mGlTextureObject);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(-2, 3, 1.5);
            var a = new Random().Next(10);
            //Gl.glRotated(3, 0, 6, 10);
            Gl.glRotated(a-5, a - 1, a - 4, a + 1);
            Glut.glutSolidTeapot(0.5);
            Gl.glPopMatrix();
            Gl.glFlush();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        public void DrawRack()
        {           
            foreach (Pillar pillar in Pillar.GetPillars())
            {
                Gl.glClearColor(255, 255, 255, 1);
                Gl.glLoadIdentity();
                Gl.glTranslated(pillar.Center.X, pillar.Center.Y, pillar.Center.Z);
                Glut.glutSolidCylinder(pillar.Radius, 6, 10, 10);
                Gl.glPopMatrix();
                Gl.glFlush();
            }
         
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, _shelfTexture.mGlTextureObject);

            Gl.glPushMatrix();
            Gl.glBegin(Gl.GL_QUADS);

            Point lowerLeftPoint = new Point(0 - 5, 0 - 5, 6 - 5);
            Point topRightPoint = new Point(5 - 5, 10 - 5, 6 - 5);
            Point lowerRightPoint = new Point(5 - 5, 0 - 5, 6 - 5);
            Point topLeftPoint = new Point(0 - 5, 10 - 5, 6 - 5);

            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);

            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);

            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);

            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);

            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);

            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);

            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        public void DrawFloor()
        {
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, _floorTexture.mGlTextureObject);

            Gl.glPushMatrix();
            Gl.glBegin(Gl.GL_QUADS);

            Point lowerLeftPoint = new Point(-20, -40, 0);
            Point topRightPoint = new Point(20, 40, 0);
            Point lowerRightPoint = new Point(20, -40, 0);
            Point topLeftPoint = new Point(-20, 40, 0);

            Gl.glTexCoord2f(0.0f, 0.0f);
            Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f);
            Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f);
            Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f);
            Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);

            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);

            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);

            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);

            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);

            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f((float)lowerLeftPoint.X, (float)lowerLeftPoint.Y, (float)lowerLeftPoint.Z);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f((float)lowerRightPoint.X, (float)lowerRightPoint.Y, (float)lowerRightPoint.Z);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f((float)topRightPoint.X, (float)topRightPoint.Y, (float)topRightPoint.Z);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f((float)topLeftPoint.X, (float)topLeftPoint.Y, (float)topLeftPoint.Z);

            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        #endregion

        #region Boom
        public void ChangeExplosion(float global_time)
        {
            Boooom(CalculateExplosionCoordinates(), global_time);
        }

        private void Boooom(Explosion boom, float time_start)
        {
            Random rnd = new Random();
            if (!boom.IsDisplayList)
            {
                CreateDisplayList(boom);
            }
            for (int ax = 0; ax < boom._particles_now; ax++)
            {
                boom.PartilceArray[ax] = new Partilce(boom.position[0], boom.position[1], boom.position[2], 5.0f, 10, time_start);
                int direction_x = rnd.Next(1, 3);
                int direction_y = rnd.Next(1, 3);
                int direction_z = rnd.Next(1, 3);
                if (direction_x == 2)
                    direction_x = -1;
                if (direction_y == 2)
                    direction_y = -1;
                if (direction_z == 2)
                    direction_z = -1;
                float _power_rnd = rnd.Next((int)boom._power / 20, (int)boom._power);
                boom.PartilceArray[ax].SetAttenuation(boom._power / 2.0f);
                boom.PartilceArray[ax].SetPower(_power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_x, _power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_y, _power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_z);
            }
            boom.IsStart = true;
        }

        private void CreateDisplayList(Explosion boom)
        {
            boom.DisplayListNom = Gl.glGenLists(1);
            Gl.glNewList(boom.DisplayListNom, Gl.GL_COMPILE);
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0.02f, 0.02f, 0);
            Gl.glVertex3d(0.02f, 0, -0.02f);
            Gl.glEnd();
            Gl.glEndList();
            boom.IsDisplayList = true;
        }

        private void Calculate(Explosion boom, float time)
        {
            if (boom.IsStart)
            {
                for (int ax = 0; ax < boom._particles_now; ax++)
                {
                    if (boom.PartilceArray[ax].IsLife())
                    {
                        boom.PartilceArray[ax].UpdatePosition(time);
                        Gl.glPushMatrix();
                        float size = boom.PartilceArray[ax].GetSize();
                        Gl.glTranslated(boom.PartilceArray[ax].GetPositionX(), boom.PartilceArray[ax].GetPositionY(), boom.PartilceArray[ax].GetPositionZ());
                        Gl.glScalef(size, size, size);
                        Gl.glCallList(boom.DisplayListNom);
                        Gl.glPopMatrix();
                        if (boom.PartilceArray[ax].GetPositionY() < 0)
                        {
                            boom.PartilceArray[ax].InvertSpeed(1, 0.6f);
                            boom.PartilceArray[ax].position[1] = 0;
                        }
                    }
                }
            }
        }

        public Explosion CalculateExplosionCoordinates()
        {
            _boom.SetNewPosition((float)_blockCoord.X, (float)_blockCoord.Y, (float)_blockCoord.Z);
            _boom.SetNewPower(50);
            return _boom;
        }

        #endregion

        private void OnBoxBarChanged(object sender, EventArgs e) => _boxAngle = trackBarBox.Value;

        private void OnAnimationChenged(object sender, EventArgs e) => _randomAnimationUsed = checkBoxAnimation.Checked;

        private void HotKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Camera morion — W/A/S/D \n Camera rotation — Q/A \n Camera incline — X/C \n Zoom — M/N \n Transition — K/J/K/L \n Explosion — B";
            MessageBox.Show(info, "Hot keys", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
    }
}