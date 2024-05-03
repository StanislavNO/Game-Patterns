using UnityEngine;

namespace Assets.Project2.Task3
{
    public class GroundedChecker : MonoBehaviour
    {
        [SerializeField] private LayerMask _ground;
        [SerializeField, Range(0.1f, 1f)] private float _distance;

        private Transform _transform;

        public bool IsGround;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            IsGround = Physics.CheckSphere(
                _transform.position,
                _distance,
                _ground);
        }
    }
}