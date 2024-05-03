using System;

namespace Assets.Project2.Task3
{
    public class CharacterData 
    {
        public float XVelocity;
        public float YVelocity;

        private float _speed;
        private float _xInput;

        public float XInput
        {
            get => _xInput;
            set
            {
                if (value < -1 || value > 1)
                    throw new ArgumentOutOfRangeException();

                _xInput = value;
            }
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _speed = value;
            }
        }
    }
}