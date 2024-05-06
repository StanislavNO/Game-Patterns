using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project3
{
    public class CharacterLevel : ILevelCounter, ILevelUpper
    {
        private int _grade;
        private int _upgradeCounter;
        private int _pointCounter;

        public CharacterLevel()
        {

        }

        public event Action<int> OnLevelChanged;

        public void AddPoint(int value)
        {
            throw new NotImplementedException();
        }
    }
}