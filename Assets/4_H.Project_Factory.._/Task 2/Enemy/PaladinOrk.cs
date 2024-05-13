using UnityEngine;

namespace Assets.Project4.Task2
{
    public class PaladinOrk : Paladin
    {
        private float _coefficient = 2f;

        protected override int HandleDamage(int damage)
        {
            Debug.Log("Орк не чувствует половины урона");

            int result = Mathf.Abs((int)(damage / _coefficient));
            return result;
        }
    }
}