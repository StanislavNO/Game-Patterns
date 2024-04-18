using System;
using UnityEngine;

namespace Assets.Task4
{
    public class Enemy : MonoBehaviour
    {
        public void Die()
        {
            Destroy(gameObject);
        }
    }
}