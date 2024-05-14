using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
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
