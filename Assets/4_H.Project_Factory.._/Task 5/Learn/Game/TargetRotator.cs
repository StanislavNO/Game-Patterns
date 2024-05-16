using UnityEngine;

public class TargetRotator : MonoBehaviour
{
    [SerializeField] private Camera _target;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        transform.LookAt(_target.transform.position);
    }
}
