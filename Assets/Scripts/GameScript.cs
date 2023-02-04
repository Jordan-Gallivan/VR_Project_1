using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private EnergyMeter em;
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private int currWeapon;
    
    // Start is called before the first frame update
    void Start()
    {
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
        this.pulse = GameObject.Find("Pulsar").GetComponent<Pulse>();
        this.str = GameObject.Find("Strength").GetComponent<Strength>();
        this.uni = GameObject.Find("Unibeam").GetComponent<Unibeam>();
        this.sword = GameObject.Find("Sword").GetComponent<Sword>();

        this.weapons = new Object[4];
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Assets/Scripts/GameScript.cs
        if(Input.GetKey(KeyCode.F))
        {
            //weapons[0].useWeapon();
        }
        else if(Input.GetKey(KeyCode.G))
        {
            //weapons[1].useWeapon();
        }
        else if( Input.GetKey(KeyCode.H))
        {
            //weapons[2].useWeapon();
        }
        else if(Input.GetKey(KeyCode.J))
        {
            //weapons[3].useWeapon();
        }
        else
        {
             
        }
=======
        // these need to be updated based on the directions on the hand controller, 
        // currently just keys on the keyboard
        if (Input.GetKeyDown("a")) this.currWeapon = 0;
        if (Input.GetKeyDown("s")) this.currWeapon = 1;
        if (Input.GetKeyDown("d")) this.currWeapon = 2;
        if (Input.GetKeyDown("f")) this.currWeapon = 3;
        
        // this needs to be changed to the trigger
        while (Input.GetKeyDown("space"))
        {
            float energyUsed = this.weapons[this.currWeapon].useWeapon();
            this.em.decreaseEnergy(energyUsed);
        }
        
>>>>>>> 9a3b6a58fb696c003e6d71d4653ade7c83d6016e:Assets/GameScript.cs
    }
}