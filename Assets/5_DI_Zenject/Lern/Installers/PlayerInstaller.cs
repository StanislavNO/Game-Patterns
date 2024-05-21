using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _prefab;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private PlayerStatConfig _config;

        public override void InstallBindings()
        {
            BindConfig();
            BindInstance();
        }

        private void BindInstance()
        {
            Player player = Container.InstantiatePrefabForComponent<Player>
                (_prefab, _spawnPoint.position, Quaternion.identity, null);

            Container.BindInterfacesAndSelfTo<Player>()
                     .FromInstance(player).AsSingle();
        }

        private void BindConfig()
        {
            Container.Bind<PlayerStatConfig>().FromInstance(_config).AsSingle();
        }
    }
}