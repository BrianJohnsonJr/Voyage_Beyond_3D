using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class CoinCollectTask : MonoBehaviour
    {
        public int numCoinsToCollect = 1;
        public bool allCoinsCollected = false;

        private int numCoinsCollected = 0;

        public void CoinCollected(){
            numCoinsCollected++;

            if (numCoinsCollected >= numCoinsToCollect){
                allCoinsCollected = true;
            }
        }
    }
}
