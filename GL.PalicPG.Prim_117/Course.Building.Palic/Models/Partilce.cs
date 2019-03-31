
namespace Course.Building.Palic.Models
{
    public class Partilce
    {
        // позиция частицы
        public float[] position { get; set; }
        // размер
        public float _size { get; set; }
        // время жизни
        public float _lifeTime { get; set; }

        // вектор гравитации 
        public float[] Grav { get; set; }
        // ускорение частицы
        public float[] power { get; set; }
        // коэфичент затухания силы
        public float attenuation { get; set; }

        // набранная скорость
        public float[] speed { get; set; }

        // временной интервал активации частицы
        public float LastTime { get; set; }

        // конструктор класса
        public Partilce(float x, float y, float z, float size, float lifeTime, float start_time)
        {
            //default
            LastTime = 0;

            // записываем все начальные настройки частицы, устанавливаем начальный коэфицент затухания
            // и обнуляем скорость и силу приложенную к частице
            _size = size;
            _lifeTime = lifeTime;

            position = new float[3];
            position[0] = x;
            position[1] = y;
            position[1] = z;

            speed = new float[3];
            speed[0] = 0;
            speed[1] = 0;
            speed[2] = 0;

            Grav = new float[3];
            Grav[0] = 0;
            Grav[1] = -9.8f;
            Grav[2] = 0;

            attenuation = 3.33f;

            power = new float[3];
            power[0] = 0;
            power[0] = 0;
            power[0] = 0;

            LastTime = start_time;

        }

        // функция установка ускорения, действующего на частицу
        public void SetPower(float x, float y, float z)
        {
            power[0] = x;
            power[1] = y;
            power[2] = z;
        }

        // инвертирование скорости частицы по заданной оси, с указанным затуханием 
        // удобно использовать, для простой демонстрации столкновений, например с землей
        public void InvertSpeed(int os, float attenuation)
        {
            speed[os] *= -1 * attenuation;
        }

        // получение размера частицы
        public float GetSize()
        {
            return _size;
        }

        // установка нового значения затухания
        public void setAttenuation(float new_value)
        {
            attenuation = new_value;
        }

        // обновление позиции частицы
        public void UpdatePosition(float timeNow)
        {

            // орпределяем разницу во времени прошедшую с послднего обновления
            // позиции частицы. (ведь таймер может быть не фиксированный)
            float dTime = timeNow - LastTime;
            _lifeTime -= dTime;

            // обновляем последнюю отметку временного интервала
            LastTime = timeNow;

            // перерасчитываем ускорение, движущее частицу, с учетом затухания
            for (int a = 0; a < 3; a++)
            {

                if (power[a] > 0)
                {
                    power[a] -= attenuation * dTime;

                    if (power[a] <= 0)
                        power[a] = 0;
                }

                // перерасчитываем позицию частицы с учетом гравитации, вектора ускорения и прощедший промежуток времени
                position[a] += (speed[a] * dTime + (Grav[a] + power[a]) * dTime * dTime);

                // обновляем скорость частицы
                speed[a] += (Grav[a] + power[a]) * dTime;
            }
        }

        // проверка, не вышло ли время жизни частицы
        public bool isLife()
        {
            if (_lifeTime > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // получение координат частицы
        public float GetPositionX()
        {
            return position[0];
        }
        public float GetPositionY()
        {
            return position[1];
        }
        public float GetPositionZ()
        {
            return position[2];
        }

    }
}
