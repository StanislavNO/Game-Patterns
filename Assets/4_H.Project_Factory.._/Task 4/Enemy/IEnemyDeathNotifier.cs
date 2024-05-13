using System;

namespace Assets.Project4.Task4
{
    public interface IEnemyDeathNotifier
    {
        event Action<Enemy> Notified;
    }
}
