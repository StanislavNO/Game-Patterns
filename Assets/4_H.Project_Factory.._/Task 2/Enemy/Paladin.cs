using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public abstract class Paladin : MonoBehaviour, IEnemy
    {
        public void MoveTo(Vector3 at)
        {
            transform.position = at;
        }
    }
}