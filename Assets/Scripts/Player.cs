using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine {
    public class Player {
        public string Name { get; set; }
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public int Level { get; set; }
        public int Mana { get; set; }
        public int CurrentMana { get; set; }
        public int Experience { get; set; }
        public int CurrentExperience { get; set; }
        public int AttackStrength { get; set; }
        public int MagicStrength { get; set; }


        public void DamageTaken(int numberOfDamagePoints) {
            CurrentHealth = System.Math.Max(CurrentHealth - numberOfDamagePoints, 0);
        }

        public void Healing(int numberOfHitPointsToHeal){
            CurrentHealth = System.Math.Min(CurrentHealth + numberOfHitPointsToHeal, Health);
        }

        public void ManaRegen(int numberOfManaPoints){
            CurrentHealth = System.Math.Min(CurrentHealth + numberOfManaPoints, Health);
        }

        public void GainExperience(int numberOfExperienceGained) {
            CurrentMana = System.Math.Min(CurrentMana + numberOfExperienceGained, Mana);

            if (CurrentExperience == Experience) {
                Debug.Log("this is it");
                Level += 1;
                CurrentExperience = 0;
                Experience *= 2;
            }
        }
    }
}