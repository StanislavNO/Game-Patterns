using UnityEngine;

namespace Assets.Task3
{
    public class Florist : Seller
    {
        protected override void ShowProduct()
        {
            Debug.Log("Всяческие цветы");
        }
    }
}
