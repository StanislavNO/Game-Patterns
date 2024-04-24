using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bouncing : MonoBehaviour
{
    [SerializeField] private float _sphereRadius;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private Collider _collider;
    [SerializeField] private Transform _phantom;

    private Transform _transform;
    private Rigidbody _rigidBody;
    private Vector3 _point = Vector3.zero;

    private void Awake()
    {
        _transform = transform;
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _point = _collider.ClosestPoint(_transform.position);

        float distance = (_point - transform.position).magnitude;

        if (distance > _sphereRadius * 1f)
        {
            _phantom.localScale = Vector3.one * 1f;
        }
        else
        {
            _phantom.rotation = Quaternion.LookRotation(_point - _transform.position);

            _phantom.localScale = new Vector3(
                _phantom.localScale.x,
                _phantom.localScale.y,
                (distance / _sphereRadius));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidBody.velocity = Vector3.up * _jumpSpeed;
    }
}
