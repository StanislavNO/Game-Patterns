using Zenject;

namespace Assets.Project5.DI
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemyFactory>().AsSingle();
        }
    }
}