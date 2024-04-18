using System.Collections;
using UnityEngine;

namespace Assets.Task4
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private StartDisplay _startDisplay;

        private VictoryHandler _handler;

        private void Awake()
        {
            Instantiate(_startDisplay);
            _startDisplay.Construct(this);

            DontDestroyOnLoad(this);
        }

        public void SetHandler(VictoryHandler handler)
        {
            _handler = handler;
        }
    }
}