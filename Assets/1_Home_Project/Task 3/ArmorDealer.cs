using UnityEngine;

namespace Assets.Task3
{
    public class ArmorDealer : Seller
    {
        public static readonly int MinReputation = 50;

        protected override void ShowProduct()
        {
            Debug.Log("Всяческая броня и оружие");
        }
    }
}
