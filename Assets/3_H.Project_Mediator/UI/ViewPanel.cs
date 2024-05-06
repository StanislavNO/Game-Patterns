using System;
using System.Collections;
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

        public void ShowRestart() =>
            _restart.gameObject.SetActive(true);

        public void HideRestart() =>
            _restart.gameObject.SetActive(false);
    }
}