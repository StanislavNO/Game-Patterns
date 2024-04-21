using UnityEngine;

namespace Assets.Task4
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;

        private VictoryHandler _handler;

        private void OnEnable()
        {
            _playerInput.EnemyDied += InitEnemyTarget;
            _playerInput.EnemyDied += UpdateHandler;
        }

        private void OnDisable()
        {
            if (_handler == null)
                return;

            _playerInput.EnemyDied -= InitEnemyTarget;
            _playerInput.EnemyDied -= UpdateHandler;
        }

        public void SetHandler(VictoryHandler handler)
        {
            _handler = handler;
        }

        private void UpdateHandler(Enemy enemy)
        {
            if (_handler == null)
                return;

            _handler.Update(enemy);
        }

        private void InitEnemyTarget(Enemy enemy)
        {
            _handler.SetTarget(enemy.Color);
            _playerInput.EnemyDied -= InitEnemyTarget;
        }
    }
}