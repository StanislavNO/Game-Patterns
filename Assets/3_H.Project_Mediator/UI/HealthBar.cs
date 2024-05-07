using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Project3
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private float _speed;

        private int _size;

        public void Construct(int maxHealth)
        {
            _size = maxHealth;

            _slider.maxValue = 1;
            _slider.wholeNumbers = false;
        }

        public void WriteHealth(int healthPoint)
        {
            float percent = 100f;
            float _normalizeHealth;

            _normalizeHealth = (_slider.maxValue / percent) *
                               (_size / percent * healthPoint);

            while (_slider.value != _normalizeHealth)
            {
                _slider.value = Mathf.MoveTowards(
                    _slider.value,
                    _normalizeHealth,
                    Time.deltaTime * _speed);
            }
        }
    }
}