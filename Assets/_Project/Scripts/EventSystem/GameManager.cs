using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public class GameManager : MonoBehaviour
    {
    public static GameManager Instance { get; private set; }
        
        public int Score { get; private set; }
        
        void Awake() {
            if (Instance == null) {
                Instance = this;
            } else {
                Destroy(gameObject);
            }
        }
        
        public void AddScore(int score) {
            Score += score;
        }
    }
}
