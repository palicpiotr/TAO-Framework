
namespace Course.Building.Palic.Models
{
    public class Partilce
    {
        public float[] position { get; set; }
        public float _size { get; set; }
        public float _lifeTime { get; set; }
        public float[] Grav { get; set; }
        public float[] Power { get; set; }
        public float Attenuation { get; set; }
        public float[] Speed { get; set; }
        public float LastTime { get; set; }

        public Partilce(float x, float y, float z, float size, float lifeTime, float start_time)
        {
            LastTime = 0;
            _size = size;
            _lifeTime = lifeTime;

            position = new float[3];
            position[0] = x;
            position[1] = y;
            position[1] = z;

            Speed = new float[3];
            Speed[0] = 0;
            Speed[1] = 0;
            Speed[2] = 0;

            Grav = new float[3];
            Grav[0] = 0;
            Grav[1] = -9.8f;
            Grav[2] = 0;

            Attenuation = 3.33f;

            Power = new float[3];
            Power[0] = 0;
            Power[0] = 0;
            Power[0] = 0;

            LastTime = start_time;

        }

        public void SetPower(float x, float y, float z)
        {
            Power[0] = x;
            Power[1] = y;
            Power[2] = z;
        }

        public void InvertSpeed(int os, float attenuation) => Speed[os] *= -1 * attenuation;

        public float GetSize() => _size;

        public void SetAttenuation(float new_value) => Attenuation = new_value;

        public void UpdatePosition(float timeNow)
        {
            float dTime = timeNow - LastTime;
            _lifeTime -= dTime;
            LastTime = timeNow;
            for (int a = 0; a < 3; a++)
            {
                if (Power[a] > 0)
                {
                    Power[a] -= Attenuation * dTime;
                    if (Power[a] <= 0)
                        Power[a] = 0;
                }
                position[a] += (Speed[a] * dTime + (Grav[a] + Power[a]) * dTime * dTime);
                Speed[a] += (Grav[a] + Power[a]) * dTime;
            }
        }

        public bool IsLife() => _lifeTime > 0;

        public float GetPositionX() => position[0];

        public float GetPositionY() => position[1];

        public float GetPositionZ() => position[2];
        
    }
}
