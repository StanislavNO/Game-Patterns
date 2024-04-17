using UnityEngine;

namespace Assets.Task2
{
    public class StandardWeapon : IWeapon
    {
        public void Shoot()
        {
            Debug.Log($"Выстрел из {nameof(StandardWeapon)} бесконечным патроном");
        }
    }
}