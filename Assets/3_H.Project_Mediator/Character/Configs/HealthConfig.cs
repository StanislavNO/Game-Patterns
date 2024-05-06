﻿using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project3
{
    [Serializable]
    public class HealthConfig
    {
        [field: SerializeField][Range(1,100)] private int MaxHealth;
    }
}