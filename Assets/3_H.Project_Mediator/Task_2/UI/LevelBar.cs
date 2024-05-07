using TMPro;
using UnityEngine;

namespace Assets.Project3
{
    public class LevelBar : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void WriteLevel(int value) =>
            _text.text = $"{value}";
    }
}