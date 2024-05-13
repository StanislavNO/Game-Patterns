using Assets.Project4.Task4;
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Factory", fileName = "EnemyFactory")]
public class EnemyFactory : ScriptableObject
{
    [SerializeField] private Ork _orkPrefab;
    [SerializeField] private Human _humanPrefab;
    [SerializeField] private Elf _elfPrefab;
    [SerializeField] private Robot _robotPrefab;

    public Enemy Create(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Elf:
                return Instantiate(_elfPrefab);

            case EnemyType.Human:
                return Instantiate(_humanPrefab);

            case EnemyType.Ork:
                return Instantiate(_orkPrefab);

            case EnemyType.Robot:
                return Instantiate(_robotPrefab);

            default:
                throw new ArgumentException(nameof(enemyType));
        }
    }
}
