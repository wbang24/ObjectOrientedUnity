using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine;

public class GameController : MonoBehaviour
{
    private Player _player;
    private Zombie _zombie;
    private Boss _boss;


    // Start is called before the first frame update
    void Start()
    {
        _player = new Player
        {
            Health = 10,
            CurrentHealth = 10,
            Name = "Wayland",
            CurrentExperience = 0,
            Experience = 100
        };

        _zombie = new Zombie(10, 2, 100);
        _boss = new Boss(20, 5, 300);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            _zombie.DamageTaken(2);
            Debug.Log(_zombie.CurrentHealth);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            _boss.DamageTaken(2);
            Debug.Log(_boss.CurrentHealth);

        }
    }

}
