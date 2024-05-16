using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class ElfHealth : IHealth
    {
        private readonly int TicksCount;

        private IHealth _health;
        private float _healDuration;
        private int _additionalHeal;

        private MonoBehaviour _context;
        private Coroutine _healAndDelay;

        public ElfHealth(IHealth healthStat, MonoBehaviour context, PlayerConfig config)
        {
            _health = healthStat;
            _context = context;

            _healDuration = config.ElfStat.HealDuration;
            _additionalHeal = config.ElfStat.AdditionalHeal;
            TicksCount = config.ElfStat.TicksCount;
        }

        public int Value => _health.Value;
        public int MaxValue => _health.MaxValue;

        public void Add(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _health.Add(value);

            if (_healAndDelay != null)
                _context.StopCoroutine(_healAndDelay);

            _healAndDelay = _context.StartCoroutine(Heal());
        }

        public void Reduce(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _health.Reduce(value);
        }

        private IEnumerator Heal()
        {
            float tickDuration = _healDuration / TicksCount;
            int healPerTick = _additionalHeal / TicksCount;
            WaitForSeconds delay = new(tickDuration);

            for (int i = 0; i < TicksCount; i++)
            {
                _health.Add(healPerTick);

                yield return delay;
            }
        }
    }
}