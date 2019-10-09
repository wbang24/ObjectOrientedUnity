using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine {
    public class Enemy {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int DamageDealt { get; set; }
        public int ExpWorth { get; set; }

        public void DamageTaken(int numberOfDamagePoints){
            CurrentHealth = System.Math.Max(CurrentHealth - numberOfDamagePoints, 0);

            if (CurrentHealth == 0) {
                Debug.Log("Enemy Dead");
            }
        }
    }
}