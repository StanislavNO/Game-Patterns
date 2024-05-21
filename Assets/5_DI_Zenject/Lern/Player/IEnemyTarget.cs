using UnityEngine;

namespace Assets.Project5.DI
{
    public interface IEnemyTarget : IDamageable
    {
        Vector3 Position { get; }
    }
}