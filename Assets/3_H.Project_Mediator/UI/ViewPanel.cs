using UnityEngine;
using UnityEngine.UI;

namespace Assets.Project3
{
    public class ViewPanel : MonoBehaviour
    {
        [SerializeField] private Button _restart;
        [SerializeField] private Button _damage;
        [SerializeField] private Button _levelUp;

        public Button Restart => _restart;
        public Button Damage => _damage;
        public Button LevelUp => _levelUp;

        public void ShowRestartButton() =>
            _restart.gameObject.SetActive(true);

        public void HideRestartButton() =>
            _restart.gameObject.SetActive(false);

        public void ShowBaseButtons()
        {
            Damage.gameObject.SetActive(true);
            LevelUp.gameObject.SetActive(true);
        }

        public void HideBaseButtons()
        {
            Damage.gameObject.SetActive(false);
            LevelUp.gameObject.SetActive(false);
        }
    }
}