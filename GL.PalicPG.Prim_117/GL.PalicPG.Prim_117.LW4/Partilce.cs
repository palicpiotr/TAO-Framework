using System;

namespace GL.PalicPG.Prim_117.LW4
{
    class Partilce
    {
        private readonly float[] _position = new float[3];
        private readonly float _size;
        private float _lifeTime;
        private readonly float[] _grav = new float[3];
        private readonly float[] _power = new float[3];
        private float _attenuation;
        private readonly float[] _speed = new float[3];
        private float _lastTime = 0;
        private float _rotateDegraee = 0f;
        public float[] _rotateVector = new float[3];

        public float RotateDegraee
        {
            get
            {
                _rotateDegraee += (_speed[0] + _speed[1] + _speed[2]) * 2f;
                if (_rotateDegraee > 360) _rotateDegraee -= 360f;
                return _rotateDegraee;
            }
            set => _rotateDegraee = value;
        }

        public Partilce(float x, float y, float z, float size, float lifeTime, float start_time)
        {
            Random rnd = new Random();
            _rotateVector[0] = (float)rnd.NextDouble();
            _rotateVector[1] = _rotateVector[0] / 2;
            _rotateVector[2] = _rotateVector[1];
            _size = size;
            _lifeTime = lifeTime;
            _position[0] = x;
            _position[1] = y;
            _position[1] = z;
            _speed[0] = 0;
            _speed[1] = 0;
            _speed[2] = 0;
            _grav[0] = 0;
            _grav[1] = -9.8f;
            _grav[2] = 0;
            _attenuation = 3.33f;
            _power[0] = 0;
            _power[0] = 0;
            _power[0] = 0;
            _lastTime = start_time;
        }

        public void SetPower(float x, float y, float z)
        {
            _power[0] = x;
            _power[1] = y;
            _power[2] = z;
        }

        public void InvertSpeed(int os, float attenuation) => _speed[os] *= -1 * attenuation;

        public float GetSize() => _size;

        public void SetAttenuation(float new_value) => _attenuation = new_value;

        public void UpdatePosition(float timeNow)
        {
            float dTime = timeNow - _lastTime;
            _lifeTime -= dTime;
            _lastTime = timeNow;
            for (int a = 0; a < 3; a++)
            {
                if (_power[a] > 0)
                {
                    _power[a] -= _attenuation * dTime;
                    if (_power[a] <= 0)
                        _power[a] = 0;
                }
                _position[a] += (_speed[a] * dTime + (_grav[a] + _power[a]) * dTime * dTime);
                _speed[a] += (_grav[a] + _power[a]) * dTime;
            }
        }

        public bool IsLife() => _lifeTime > 0;

        public float GetPositionX() => _position[0];

        public float GetPositionY() => _position[1];

        public float GetPositionZ() => _position[2];

    }
}
