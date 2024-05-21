using UnityEngine;

namespace Assets.Project5.DI
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private EnemySpawner _spawner;

        private void Awake()
        {
            _spawner.StartWork();
        }
    }
}