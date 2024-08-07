using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class GameRespawn : MonoBehaviour
    {
        public float threshold;
        // Start is called before the first frame update
        void FixedUpdate(){
            if(transform.position.y < threshold){
                 transform.position = new Vector3(-0.8499999f, 0, -6.93f);
            }
        }
    }
}
