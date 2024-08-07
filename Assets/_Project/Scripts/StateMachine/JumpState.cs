using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class JumpState : BaseState 
    {
        public JumpState(PlayerController player, Animator animator) : base(player, animator) { }

        public override void OnEnter() {
            animator.CrossFade(JumpHash, crossFadeDuration);
        }

        public override void FixedUpdate() {
            //player.HandleJump();
            //player.HandleMovement();
        }
    }
}
