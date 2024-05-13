using System;

namespace Assets.Project4.Task4
{
    public class Score : IDisposable
    {
        private IEnemyDeathNotifier _notifier;
        private EnemyVisitor _visitor;

        public Score(IEnemyDeathNotifier notifier)
        {
            _notifier = notifier;
            _notifier.Notified += OnEnemyKilled;

            _visitor = new EnemyVisitor();
        }

        public int Value => _visitor.Score;

        public void Dispose()
        {
            _notifier.Notified -= OnEnemyKilled;
        }

        public void OnEnemyKilled(Enemy enemy)
        {
            enemy.Accept(_visitor);
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Elf elf)
            {
                Score += 1;
            }

            public void Visit(Ork ork)
            {
                Score += 10;
            }

            public void Visit(Human human)
            {
                Score += 20;
            }

            public void Visit(Robot robot)
            {
                Score += 30;
            }
        }
    }
}