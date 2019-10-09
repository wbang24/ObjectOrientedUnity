using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine;

public class Boss : Enemy {

    public Boss(int health, int damage, int exp){
        CurrentHealth = health;
        DamageDealt = damage;
        ExpWorth = exp;
    }
}
