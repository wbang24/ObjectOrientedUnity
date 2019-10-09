using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine;

public class Zombie : Enemy {

    public Zombie(int health, int damage, int exp){
        CurrentHealth = health;
        DamageDealt = damage;
        ExpWorth = exp;
    }
}
