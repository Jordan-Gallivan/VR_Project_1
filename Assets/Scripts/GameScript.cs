using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public EnergyMeter em;
    public GameObject pulseObj;
    public GameObject strObj;
    public GameObject uniObj;
    public GameObject swordObj;
    public GameObject nanoObj;
    public TextMeshPro weaponDisplay;
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private Nano nano;
    
    private int currWeapon;
    private Weapons[] weapons;
    
    // Start is called before the first frame update
    void Start()
    {
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
        this.pulse = pulseObj.GetComponent<Pulse>();
        this.str = strObj.GetComponent<Strength>();
        this.uni = uniObj.GetComponent<Unibeam>();
        this.sword = swordObj.GetComponent<Sword>();
        this.nano = nanoObj.GetComponent<Nano>();
        
        this.weapons = new Weapons[5];
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;
        this.weapons[4] = nano;

        this.currWeapon = 0;

    }

    // Update is called once per frame
    void Update()
    {

        // these need to be updated based on the directions on the hand controller, 
        // currently just keys on the keyboard
        // if (Input.GetKeyDown(KeyCode.F)) this.currWeapon = 0;
        // if (Input.GetKeyDown(KeyCode.G)) this.currWeapon = 1;
        // if (Input.GetKeyDown(KeyCode.H)) this.currWeapon = 2;
        // if (Input.GetKeyDown(KeyCode.J)) this.currWeapon = 3;
        
        // Single Button push iterates through weapons
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.currWeapon++;
            if (this.currWeapon > 4) this.currWeapon = 0;

            this.weaponDisplay.text = this.weapons[currWeapon].weaponName();
        }
        
        // this needs to be changed to the trigger
        if (Input.GetKeyDown("space"))
        {
            // i cant get the method call to another script to work.  please tinker with this part of the script
            // and see what you can do to make this work.
            float energyUsed = this.weapons[currWeapon].useWeapon();
            this.em.decreaseEnergy(energyUsed);

        }

        if (Input.GetKeyUp("space"))
        {
            this.weapons[currWeapon].secureWeapon();
        }

    }
}
