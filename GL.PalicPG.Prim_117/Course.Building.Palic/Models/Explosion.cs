
namespace Course.Building.Palic.Models
{
    public class Explosion
    {
        public float[] position { get; set; }
        public float _power { get; set; }
        public int MAX_PARTICLES { get; set; }
        public int _particles_now { get; set; }
        public bool IsStart { get; set; }
        public Partilce[] PartilceArray { get; set; }
        public bool IsDisplayList { get; set; }
        public int DisplayListNom { get; set; }

        public Explosion(float x, float y, float z, float power, int particle_count)
        {
            MAX_PARTICLES = 1000;
            IsStart = false;
            IsDisplayList = false;
            DisplayListNom = 0;
            position = new float[3];
            position[0] = x;
            position[1] = y;
            position[2] = z;
            _particles_now = particle_count;
            _power = power;
            if (particle_count > MAX_PARTICLES)
            {
                particle_count = MAX_PARTICLES;
            }
            PartilceArray = new Partilce[particle_count];
        }

        public void SetNewPosition(float x, float y, float z)
        {
            position[0] = x;
            position[1] = y;
            position[2] = z;
        }

        public void SetNewPower(float new_power)
        {
            _power = new_power;
        }
    }
}
