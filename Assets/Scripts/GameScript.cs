using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Game Object Assignment
    public EnergyMeter em;
    public GameObject pulseObj;
    public GameObject strObj;
    public GameObject uniObj;
    public GameObject swordObj;
    public GameObject nanoObj;
    public TextMeshPro weaponDisplay;
    
    // Script Assignment
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private Nano nano;
    
    // Current Weapons array
    private int currWeapon;
    private Weapons[] weapons;
    
    // Start is called before the first frame update
    void Start()
    {
        // Pull Scripts from the respective game objects
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
        this.pulse = pulseObj.GetComponent<Pulse>();
        this.str = strObj.GetComponent<Strength>();
        this.uni = uniObj.GetComponent<Unibeam>();
        this.sword = swordObj.GetComponent<Sword>();
        this.nano = nanoObj.GetComponent<Nano>();
        
        this.weapons = new Weapons[5]; //debug stop
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;
        this.weapons[4] = nano;
        
        // Initialize current weapon to strength
        this.currWeapon = 0;

        // _controller = GetComponent<SteamVR_TrackedController>;

    }

    // Update is called once per frame
    void Update()
    {
        // Single Button push iterates through weapons
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            // increment current weapon until end of array
            // reset to 0 when size of array reached
            this.currWeapon++;
            if (this.currWeapon > 4) this.currWeapon = 0;
            
            // display current weapon on HUD
            this.weaponDisplay.text = this.weapons[currWeapon].weaponName();
        }
        
        if (Input.GetKeyDown("space"))
        {
            // Use current Weapon
            float energyUsed = this.weapons[currWeapon].useWeapon();
            
            this.em.decreaseEnergy(energyUsed); // update energy 

        }

        if (Input.GetKeyUp("space"))
        {
            this.weapons[currWeapon].secureWeapon();    // terminate weapon use
        }

    }
}
