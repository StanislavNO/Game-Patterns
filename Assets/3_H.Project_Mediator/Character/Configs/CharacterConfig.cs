using System.Collections;
using UnityEngine;

namespace Assets.Project3
{
    [CreateAssetMenu(fileName = "UnitConfig", menuName = "Configs/UnitConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private HealthConfig HealthConfig;
    }
}