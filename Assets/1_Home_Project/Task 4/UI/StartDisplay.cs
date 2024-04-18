using System.Collections;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Task4
{
    public class StartDisplay : MonoBehaviour
    {
        [SerializeField] private Button _allColor;
        [SerializeField] private Button _oneColor;
        [SerializeField] private CanvasGroup Curtain;

        private EntryPoint _entryPoint;

        public void Construct(EntryPoint entryPoint)
        {
            _entryPoint = entryPoint;
        }

        private void Start()
        {
            Show();
        }

        private void OnEnable()
        {
            _allColor.onClick.AddListener(InstallAllColorHandler);
            _allColor.onClick.AddListener(Hide);

            _oneColor.onClick.AddListener(InstallOneColorHandler);
            _oneColor.onClick.AddListener(Hide);
        }

        private void OnDisable()
        {
            _allColor.onClick.RemoveListener(InstallAllColorHandler);
            _allColor.onClick.RemoveListener(Hide);

            _oneColor.onClick.RemoveListener(InstallOneColorHandler);
            _oneColor.onClick.RemoveListener(Hide);
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

        private void InstallAllColorHandler()
        {
            _entryPoint?.SetHandler(new AllColorHandler());
            TurnOffButtons();
        }

        private void InstallOneColorHandler()
        {
            _entryPoint?.SetHandler(new OneColorHandler());
            TurnOffButtons();
        }

        private void TurnOffButtons()
        {
            _oneColor.enabled = false;
            _allColor.enabled = false;
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