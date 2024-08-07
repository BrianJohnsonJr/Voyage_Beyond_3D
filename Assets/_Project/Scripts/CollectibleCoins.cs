using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Voyage_Beyond_3D
{
    public class CollectibleCoins : MonoBehaviour
    {
        public int coins;
        //public int value;

        public CoinCollectTask coinCollectTask;
        //Boolean play_animation = true;

        public void OnTriggerEnter(Collider other){
            if(other.CompareTag("Player")){
                Debug.Log("Coin Collected!");
                coinCollectTask.CoinCollected();
                gameObject.SetActive(false);
                coins = coins + 1;
                //Col.gameObject.SetActive(false);
                CoinCounter.instance.IncreaseCoins(coins);
                //play_animation = false;
            }
        }
    }
}
