using UnityEngine;

namespace Assets
{
    public class ShotGun : IWeapon
    {
        private int _maxBullet;
        private int _currencyBullet;
        private int _sizeShot;

        public ShotGun()
        {
            _maxBullet = 9;
            _currencyBullet = _maxBullet;
            _sizeShot = 3;
        }

        public void Shoot()
        {
            if (_currencyBullet == 0)
                AddBullet();

            _currencyBullet -= _sizeShot;

            Debug.Log($"Выстрел из {nameof(ShotGun)} бесконечным патроном");
        }

        private void AddBullet()
        {
            _currencyBullet = _maxBullet;
        }
    }
}