using UnityEngine;

namespace Assets.Project2.Task2
{
    public interface IMap
    {
        Transform HomePosition { get; }
        Transform WorkPosition { get; }
    }
}