using System;
using UnityEngine;

namespace Assets.Task4
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Material _material;

        private IMarker _marker;

        public void Die()
        {
            throw new NotImplementedException();
        }

        public void SetMarker(IMarker marker)
        {
            _marker = marker;
            _material.color = _marker.Color;
        }
    }
}