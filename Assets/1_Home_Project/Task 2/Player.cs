using System;
using UnityEngine;

namespace Assets.Task2
{
    public class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            SetWeapon(weapon);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
                _weapon?.Shoot();
        }

        public void SetWeapon(IWeapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            _weapon = weapon;
        }
    }
}