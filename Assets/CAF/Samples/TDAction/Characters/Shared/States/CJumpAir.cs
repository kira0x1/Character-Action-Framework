﻿using System.Collections;
using System.Collections.Generic;
using TDAction.Inputs;
using UnityEngine;

namespace TDAction.Entities.Characters
{
    public class CJumpAir : CharacterState
    {
        public override string GetName()
        {
            return "Jump (Air)";
        }

        public override void Initialize()
        {
            CharacterManager c = GetCharacterController();
            CharacterStats stats = (CharacterStats)c.entityDefinition.GetEntityStats();

            GetPhysicsManager().forceGravity.y = stats.airJumpForce;
        }

        public override void OnUpdate()
        {
            CharacterManager c = GetCharacterController();

            ((EntityPhysicsManager)c.PhysicsManager).HandleGravity();

            ((CharacterPhysicsManager)c.PhysicsManager).AirDrift();

            CheckInterrupt();
        }

        public override bool CheckInterrupt()
        {
            CharacterManager c = GetCharacterController();
            if (c.TryAttack())
            {
                return true;
            }
            if (GetPhysicsManager().forceGravity.y <= 0)
            {
                c.StateManager.ChangeState((int)EntityStates.FALL);
                return true;
            }
            return false;
        }
    }
}
