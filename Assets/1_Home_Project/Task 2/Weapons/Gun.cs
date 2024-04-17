using UnityEngine;

namespace Assets.Task2
{
    public class Gun : IWeapon
    {
        private int _maxBullet;
        private int _currencyBullet;
        private int _sizeShot;

        public Gun()
        {
            _maxBullet = 10;
            _currencyBullet = _maxBullet;
            _sizeShot = 1;
        }

        public void Shoot()
        {
            if (_currencyBullet == 0)
                AddBullet();

            _currencyBullet -= _sizeShot;

            Debug.Log($"Выстрел из {nameof(Gun)} одиночным патроном");
        }

        private void AddBullet()
        {
            _currencyBullet = _maxBullet;
        }
    }
}