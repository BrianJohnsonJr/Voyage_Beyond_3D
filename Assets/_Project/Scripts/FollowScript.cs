using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class FollowScript : MonoBehaviour
    {
        public Transform targetObj;
        void Update(){
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 10 * Time.deltaTime);
        }
    }
}
