using System;

namespace Assets.Project3
{
    public class CharacterLevel : ILevel
    {
        private const int DEFAULT_POINT = 50;
        private readonly int _size;

        private int _grade;
        private int _startGrade;
        private int _pointCounter;

        public CharacterLevel(CharacterConfig config)
        {
            _startGrade = config.LevelConfig.StartLevel;
            _grade = _startGrade;

            _size = config.LevelConfig.SizeLevel;
            _pointCounter = 0;
        }

        public event Action<int> OnLevelChanged;

        public void AddPoint() =>
            AddPoint(DEFAULT_POINT);

        public void AddPoint(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _pointCounter += value;

            if (_pointCounter >= _size)
                Upgrade();
        }

        public void Reset()
        {
            _grade = _startGrade;
            _pointCounter -= _pointCounter;

            OnLevelChanged?.Invoke(_grade);
        }

        private void Upgrade()
        {
            while (_pointCounter >= _size)
            {
                _pointCounter -= _size;
                _grade++;

                OnLevelChanged?.Invoke(_grade);
            }
        }
    }
}