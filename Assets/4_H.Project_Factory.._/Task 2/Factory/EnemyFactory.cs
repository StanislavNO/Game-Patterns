namespace Assets.Project4.Task2
{
    public abstract class EnemyFactory
    {
        protected EnemyFactory(EnemyConfig config)
        {
            Config = config;
        }

        protected EnemyConfig Config {  get; private set; }

        public abstract IEnemy Create(EnemyType enemyType);
    }
}