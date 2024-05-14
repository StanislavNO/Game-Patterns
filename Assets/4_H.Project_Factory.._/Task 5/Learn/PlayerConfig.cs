using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    [CreateAssetMenu(menuName = "Project_5", fileName = "PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public int DefaultHealth {  get; private set; }
    }
}