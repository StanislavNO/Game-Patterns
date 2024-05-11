
using UnityEngine;

namespace Assets.Project4.Task2
{
    public class WizardElf : Wizard
    {
        private int _damage = 10;

        protected override int GetDamage()
        {
            Debug.Log("Ельфийский Урон");
            return _damage;
        }
    }
}