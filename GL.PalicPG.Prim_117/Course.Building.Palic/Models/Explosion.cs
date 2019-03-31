
namespace Course.Building.Palic.Models
{
    public class Explosion
    {
        // позиция взрыва
        public float[] position { get; set; }
        // можность
        public float _power { get; set; }
        // максимальное количество частиц
        public int MAX_PARTICLES { get; set; }
        // текущее установленное количество частиц
        public int _particles_now { get; set; }

        // активирован
        public bool isStart { get; set; }

        // массив частиц на основе созданного ранее класса
        public Partilce[] PartilceArray { get; set; }

        // дисплейный список для рисования чатицы создан
        public bool isDisplayList { get; set; }
        // номер дисплейного списка для отрисовки
        public int DisplayListNom { get; set; }

        // конструктор класса, в него передаются координаты, где должен произойти взрыв, можность и количество чатиц
        public Explosion(float x, float y, float z, float power, int particle_count)
        {
            //default
            MAX_PARTICLES = 1000;
            isStart = false;
            isDisplayList = false;
            DisplayListNom = 0;

            //setting
            position = new float[3];
            position[0] = x;
            position[1] = y;
            position[2] = z;

            _particles_now = particle_count;
            _power = power;

            // если число частиц превышает максимально разрешенное
            if (particle_count > MAX_PARTICLES)
            {
                particle_count = MAX_PARTICLES;
            }

            // создаем массив частиц необходимого размера
            PartilceArray = new Partilce[particle_count];


        }

        // функция обновления позиции взрыва
        public void SetNewPosition(float x, float y, float z)
        {
            position[0] = x;
            position[1] = y;
            position[2] = z;
        }

        // установка нового значения мощности взрыва
        public void SetNewPower(float new_power)
        {
            _power = new_power;
        }
    }
}
