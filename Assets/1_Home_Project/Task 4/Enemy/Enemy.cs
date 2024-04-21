using UnityEngine;

namespace Assets.Task4
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public Colors Color { get; private set; }

        public void Die()
        {
            Destroy(gameObject);
        }
    }
}