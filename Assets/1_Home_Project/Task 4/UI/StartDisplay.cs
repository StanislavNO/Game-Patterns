using System.Collections;
using UnityEngine;

namespace Assets.Task4
{
    public class StartDisplay : MonoBehaviour
    {
        [SerializeField] private CanvasGroup Curtain;

        private ScoreManager _scorer;
        private EnemyPool _enemyPool;

        public void Construct(ScoreManager scorer, EnemyPool enemyPool)
        {
            _scorer = scorer;
            _enemyPool = enemyPool;
        }

        private void Start()
        {
            Show();
        }

        public void Hide()
        {
            StartCoroutine(DoFadeIn());
        }

        private void Show()
        {
            gameObject.SetActive(true);
            Curtain.alpha = 1f;
        }

        public void InstallAllColorHandler()
        {
            _scorer.SetHandler(new AllColorHandler(_enemyPool));
        }

        public void InstallOneColorHandler()
        {
            _scorer.SetHandler(new OneColorHandler(_enemyPool));
        }

        private IEnumerator DoFadeIn()
        {
            float fadeTime = 0.03f;
            WaitForSeconds delay = new WaitForSeconds(fadeTime);

            while (Curtain.alpha > 0)
            {
                Curtain.alpha -= fadeTime;
                yield return delay;
            }

            gameObject.SetActive(false);
        }

    }
}