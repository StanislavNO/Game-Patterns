using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public abstract class EnemyFactory
    {
        public abstract IEnemy Create();
    }

    public class OrkFactory : EnemyFactory
    {
        public override IEnemy Create()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ElfFactory : EnemyFactory
    {
        public override IEnemy Create()
        {
            throw new System.NotImplementedException();
        }
    }
}