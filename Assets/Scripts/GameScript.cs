using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public EnergyMeter em;
    public GameObject pulseObj;
    public GameObject strObj;
    public GameObject uniObj;
    public GameObject swordObj;
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private int currWeapon;
    private Weapons[] weapons;
    
    // Start is called before the first frame update
    void Start()
    {
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
        GameObject test = GameObject.Find("PulsarContainer");
        this.pulse = swordObj.GetComponent<Pulse>();
        this.str = strObj.GetComponent<Strength>();
        this.uni = uniObj.GetComponent<Unibeam>();
        this.sword = swordObj.GetComponent<Sword>();
        

        this.weapons = new Weapons[4];
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;

        this.currWeapon = 0;

    }

    // Update is called once per frame
    void Update()
    {

        // these need to be updated based on the directions on the hand controller, 
        // currently just keys on the keyboard
        if (Input.GetKeyDown(KeyCode.F)) this.currWeapon = 0;
        else if (Input.GetKeyDown(KeyCode.G)) this.currWeapon = 1;
        else if (Input.GetKeyDown(KeyCode.H)) this.currWeapon = 2;
        else if (Input.GetKeyDown(KeyCode.J)) this.currWeapon = 3;
        
        // this needs to be changed to the trigger
        else if (Input.GetKeyDown("space"))
        {
            // i cant get the method call to another script to work.  please tinker with this part of the script
            // and see what you can do to make this work.
            print(this.sword.energyUsage);
            float energyUsed = this.weapons[currWeapon].useWeapon();

        }

    }
}
