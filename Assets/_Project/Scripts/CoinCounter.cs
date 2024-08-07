using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class CoinCounter : MonoBehaviour
    {
        public static CoinCounter instance;

        public TMP_Text coinText;
        public int current_coins = 0;

        void Awake(){
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            coinText.text = "COINS: " + current_coins.ToString();
        }

        public void IncreaseCoins(int v){
            current_coins += v;
            coinText.text = "COINS: " + current_coins.ToString();
        }

        
    }
}
