using UnityEditor.SceneManagement;
using UnityEngine;

namespace Assets.Task4
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private PlayerInput _input;
        [SerializeField] private EnemyPool _enemyPool;
        [SerializeField] private ScoreManager _scorer;
        [SerializeField] private StartDisplay _startDisplay;


        private void Awake()
        {
            Init();

            _input.gameObject.SetActive(false);
        }

        private void Init()
        {
            _startDisplay.Construct(_scorer, _enemyPool);
        }
    }
}