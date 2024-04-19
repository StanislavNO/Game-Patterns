using System.Collections;
using UnityEngine;

namespace Assets.Task4
{
    public class ScoreManager : MonoBehaviour
    {
        private VictoryHandler _handler;
        private ScoreManager _scorer;

        public void Construct(ScoreManager scorer)
        {
            _scorer = scorer;
        }

        private void Update()
        {
            if (_handler == null)
                return;
        }

        public void SetHandler(VictoryHandler handler)
        {
            _handler = handler;
        }
    }
}