using System.Collections;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}