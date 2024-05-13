using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Project4.Task3
{

    [RequireComponent(typeof(Collider))]
    public class Coin : MonoBehaviour
    {
        [SerializeField] private Collider _collider;

        private Vector3 _startPosition;
        private IDeactivator _deactivator;

        public void Construct(IDeactivator deactivator)
        {
            _startPosition = transform.position;
            _deactivator = deactivator;
            _collider.isTrigger = true;
        }

        private void OnEnable()
        {
            transform.position = _startPosition;
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.TryGetComponent(out Player _))
                _deactivator.Deactivate(this);
        }
    }
}
