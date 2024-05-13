using UnityEngine;

namespace Assets.Project4.Task4
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private EnemySpawner _spawner;

        private Score _score;

        private void Awake()
        {
            _score = new(_spawner);
            _spawner.StartWork();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _spawner.KillRandomEnemy();
        }
    }
}