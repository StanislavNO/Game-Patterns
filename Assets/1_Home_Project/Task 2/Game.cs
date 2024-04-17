using System.Collections.Generic;
using UnityEngine;

namespace Assets.Task2
{
    public class Game : MonoBehaviour
    {
        private Player _player;

        private List<IWeapon> _weapons;
        private int _nextWeaponIndex = 0;

        private void Awake()
        {
            _player = new Player(new StandardWeapon());

            _weapons = new List<IWeapon>() {
                new Gun(),
                new StandardWeapon(),
                new ShotGun() };
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                ChangeWeaponToPlayer();

            _player.Update();
        }

        public void ChangeWeaponToPlayer()
        {
            if (_nextWeaponIndex == _weapons.Count)
                _nextWeaponIndex = 0;

            _player.SetWeapon(_weapons[_nextWeaponIndex]);
            _nextWeaponIndex++;
        }
    }
}