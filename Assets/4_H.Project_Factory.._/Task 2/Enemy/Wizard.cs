using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public abstract class Wizard : MonoBehaviour, IEnemy
    {
        public void MoveTo(Vector3 at)
        {
            transform.position = at;
        }
    }
}