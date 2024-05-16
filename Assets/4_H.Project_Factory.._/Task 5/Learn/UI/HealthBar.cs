using UnityEngine;
using UnityEngine.UI;

namespace Assets.Project4.Task5.Learn
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Scrollbar _scroll;

        private int _size;

        public void Construct(int maxHealth)
        {
            _size = maxHealth;
        }

        public void WriteHealth(int healthPoint)
        {
            float percent = 100f;
            float _normalizeHealth;

            _normalizeHealth = 1f / percent *
                               (_size / percent * healthPoint);

            _scroll.size = _normalizeHealth;
        }
    }
}