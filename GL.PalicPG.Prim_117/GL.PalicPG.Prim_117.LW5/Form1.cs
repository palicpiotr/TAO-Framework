using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.DevIl;

namespace GL.PalicPG.Prim_117.LW5
{
    public partial class Form1 : Form
    {
        private int rot = 0;
        private bool textureIsLoad = false;
        public string texture_name = "";
        public int imageId = 0;
        public uint mGlTextureObject = 0;

        public Form1()
        {
            InitializeComponent();
            SimpleOpenGlControl.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, SimpleOpenGlControl.Width, SimpleOpenGlControl.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(30, SimpleOpenGlControl.Width / SimpleOpenGlControl.Height, 1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            RenderTimer.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RenderTimer_Tick(object sender, EventArgs e) => Draw();

        private void Draw()
        {
            if (textureIsLoad)
            {
                rot++;
                if (rot > 360)
                    rot = 0;
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                Gl.glClearColor(255, 255, 255, 1);
                Gl.glLoadIdentity();
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject);
                Gl.glPushMatrix();
                Gl.glTranslated(0, -1, -5);
                Gl.glRotated(rot, 0, 1, 0);
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3d(1, 1, 0);
                Gl.glTexCoord2f(0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glTexCoord2f(1, 0);
                Gl.glVertex3d(0, 0, 0);
                Gl.glTexCoord2f(1, 1);
                Gl.glVertex3d(0, 1, 0);
                Gl.glTexCoord2f(0, 1);
                Gl.glEnd();
                Gl.glPopMatrix();
                Gl.glDisable(Gl.GL_TEXTURE_2D);
                SimpleOpenGlControl.Invalidate();
            }
        }

        private static uint MakeGlTexture(int Format, IntPtr pixels, int w, int h)
        {
            Gl.glGenTextures(1, out uint texObject);
            Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 1);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texObject);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);
            switch (Format)
            {
                case Gl.GL_RGB:
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;

                case Gl.GL_RGBA:
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;
            }
            return texObject;
        }

        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                Il.ilGenImages(1, out imageId);
                Il.ilBindImage(imageId);
                string url = openFileDialog1.FileName;
                if (Il.ilLoadImage(url))
                {
                    int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
                    int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);
                    int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);

                    switch (bitspp)
                    {
                        case 24:
                            mGlTextureObject = MakeGlTexture(Gl.GL_RGB, Il.ilGetData(), width, height);
                            break;
                        case 32:
                            mGlTextureObject = MakeGlTexture(Gl.GL_RGBA, Il.ilGetData(), width, height);
                            break;
                    }
                    textureIsLoad = true;
                    Il.ilDeleteImages(1, ref imageId);
                }
            }

        }
    }
}
