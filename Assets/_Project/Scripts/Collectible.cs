using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class Collectible : Entity { 
    
        [SerializeField] int score = 10; // FIXME set using Factory
        [SerializeField] IntEventChannel scoreChannel;

        void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Stylized Astronaut")) {
                scoreChannel.Invoke(score);
                Destroy(gameObject);
            }
        }
    }
}
