using UnityEngine;

namespace Assets.Project4.Task2
{
    public class WizardOrk : Wizard
    {
        protected override int GetDamage()
        {
            int damage = 7;

            Debug.Log("Урон Магии Орка");
            return damage;
        }
    }
}