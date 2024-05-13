using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public class PaladinElf : Paladin
    {
        private int _protection = 30;

        protected override int HandleDamage(int damage)
        {
            float result;
            float fullPercent = 100;
            Debug.Log("Ельфийская стихийная защита");

            result = damage / fullPercent * _protection;
            return Mathf.Abs((int)result);
        }
    }
}