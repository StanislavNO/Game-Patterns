using System;
using UnityEngine;

namespace Assets.Project3
{
    [Serializable]
    public class LevelConfig
    {
        [field: SerializeField] private int _startLevel;
        [field: SerializeField] private int _sizeLevel;

        public int StartLevel => _startLevel;
        public int SizeLevel => _sizeLevel;
    }
}