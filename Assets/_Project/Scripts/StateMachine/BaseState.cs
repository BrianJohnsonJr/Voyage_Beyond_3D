using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class BaseState : MonoBehaviour
    {
        protected readonly PlayerController player;
        protected readonly Animator animator;
        
        protected static readonly int LocomotionHash = Animator.StringToHash("Locomotion");
        protected static readonly int JumpHash = Animator.StringToHash("New State 0");

        protected const float crossFadeDuration = 0.1f;
        
        protected BaseState(PlayerController player, Animator animator) {
            this.player = player;
            this.animator = animator;
        }
        
        public virtual void OnEnter() {
            // noop
        }

        public virtual void Update() {
            // noop
        }

        public virtual void FixedUpdate() {
            // noop
        }

        public virtual void OnExit() {
            // noop
        }
    }
}
