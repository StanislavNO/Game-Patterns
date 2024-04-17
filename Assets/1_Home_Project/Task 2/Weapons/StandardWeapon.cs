using UnityEngine;

namespace Assets
{
    public class StandardWeapon : IWeapon
    {
        public void Shoot()
        {
            Debug.Log($"Выстрел из {nameof(StandardWeapon)} бесконечным патроном") ;
        }
    }
}