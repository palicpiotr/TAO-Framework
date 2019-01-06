using System;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW4
{
    public class Bang
    {

        private readonly float[] position = new float[3];
        private float _power;
        private readonly int MAX_PARTICLES = 1000;
        private readonly int _particles_now;
        private bool isStart = false;
        private readonly Partilce[] PartilceArray;
        private bool isDisplayList = false;
        private int DisplayListNom = 0;

        public Bang(float x, float y, float z, float power, int particle_count)
        {
            position[0] = x;
            position[1] = y;
            position[2] = z;
            _particles_now = particle_count;
            _power = power;
            if (particle_count > MAX_PARTICLES)
                particle_count = MAX_PARTICLES;
            PartilceArray = new Partilce[particle_count];
        }

        public void SetNewPosition(float x, float y, float z)
        {
            position[0] = x;
            position[1] = y;
            position[2] = z;
        }

        public void SetNewPower(float new_power) => _power = new_power;

        private void CreateDisplayList()
        {
            DisplayListNom = Gl.glGenLists(1);
            Gl.glNewList(DisplayListNom, Gl.GL_COMPILE);
            Gl.glBegin(Gl.GL_TRIANGLES);

            // задаем форму частицы
            Gl.glVertex3d(-0.01f, -0.01f, 0);
            Gl.glVertex3d(0.01f, 0.01f, 0);
            Gl.glVertex3d(0.01f, -0.01f, 0);

            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0.02f, 0.02f, 0);
            Gl.glVertex3d(0.02f, 0, -0.02f);

            Gl.glEnd();
            Gl.glEndList();
            isDisplayList = true;

        }

        public void Boooom(float time_start) => CreateBoom(time_start, false);

        public void BoooomForward(float time_start) => CreateBoom(time_start, true);

        private void CreateBoom(float time_start, bool forward)
        {
            Random rnd = new Random();
            if (!isDisplayList)
                CreateDisplayList();
            for (int ax = 0; ax < _particles_now; ax++)
            {
                PartilceArray[ax] = new Partilce(position[0], position[1], position[2], 5.0f, 10, time_start);

                int direction_x;
                int direction_y;
                int direction_z;

                if (forward)
                {
                    direction_x = 3;
                    direction_y = 3;
                    direction_z = 3;
                }
                else
                {
                    direction_x = rnd.Next(1, 3);
                    direction_y = rnd.Next(1, 3);
                    direction_z = rnd.Next(1, 3);
                    if (direction_x == 2)
                        direction_x = -1;
                    if (direction_y == 2)
                        direction_y = -1;
                    if (direction_z == 2)
                        direction_z = -1;
                }
                float _power_rnd = rnd.Next((int)_power / 20, (int)_power);
                PartilceArray[ax].SetAttenuation(_power / 2.0f);
                PartilceArray[ax].SetPower(_power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_x, _power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_y, _power_rnd * ((float)rnd.Next(100, 1000) / 1000.0f) * direction_z);
            }
            isStart = true;
        }

        public void Calculate(float time)
        {
            if (isStart)
            {
                for (int ax = 0; ax < _particles_now; ax++)
                {
                    if (PartilceArray[ax].IsLife())
                    {
                        PartilceArray[ax].UpdatePosition(time);
                        Gl.glPushMatrix();
                        float size = PartilceArray[ax].GetSize();
                        Gl.glTranslated(PartilceArray[ax].GetPositionX(), PartilceArray[ax].GetPositionY(), PartilceArray[ax].GetPositionZ());
                        Gl.glScalef(size, size, size);
                        Gl.glRotatef(PartilceArray[ax].RotateDegraee, PartilceArray[ax]._rotateVector[0], PartilceArray[ax]._rotateVector[1], PartilceArray[ax]._rotateVector[2]);
                        Gl.glCallList(DisplayListNom);
                        Gl.glPopMatrix();
                        if (PartilceArray[ax].GetPositionY() < 0)
                        {
                            PartilceArray[ax].InvertSpeed(1, 0.6f);
                        }
                    }
                }
            }
        }
    }
}
