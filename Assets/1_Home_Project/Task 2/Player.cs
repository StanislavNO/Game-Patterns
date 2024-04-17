using System;
using System.Collections;
using UnityEngine;

namespace Assets
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