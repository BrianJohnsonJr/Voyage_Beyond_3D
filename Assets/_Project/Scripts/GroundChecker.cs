using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] float groundDistance = 0.08f;
        [SerializeField] LayerMask groundLayers;
        
        public bool IsGrounded { get; private set; }

        void Update() {
            IsGrounded = Physics.SphereCast(transform.position, groundDistance, Vector3.down, out _, groundDistance, groundLayers);
        }

        void OnDrawGizmos(){
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, groundDistance);

            if(IsGrounded){
                Gizmos.color = Color.green;
                Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistance);
            }
        }
    }
}
