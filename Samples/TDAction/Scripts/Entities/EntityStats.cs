﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDAction.Entities
{
    public abstract class EntityStats : ScriptableObject
    {
        [Header("Aerial")]
        public float gravity;
        public float maxFallSpeed;
    }
}