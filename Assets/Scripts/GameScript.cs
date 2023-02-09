using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Game Object Assignment
    public GameObject energy;
    public GameObject pulseObj;
    public GameObject strObj;
    public GameObject uniObj;
    public GameObject swordObj;
    public GameObject nanoObj;
    public GameObject hand;
    public GameObject healingAlert;
    public TextMeshPro weaponDisplay;

    // Script Assignment
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private Nano nano;
    private EnergyMeter em;
    
    // Current Weapons array
    private int currWeapon;
    private Weapons[] weapons;
    
    // Hand Colors
    private Color handColor;
    public Color naniteColor = new Color(0.50f, 0.50f, .83f, .69f);
    
    // Nanite Variables
    private Boolean naniteActivated = false;
    private float startTime;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Pull Scripts from the respective game objects
        this.em = energy.GetComponent<EnergyMeter>();
        this.pulse = pulseObj.GetComponent<Pulse>();
        this.str = strObj.GetComponent<Strength>();
        this.uni = uniObj.GetComponent<Unibeam>();
        this.sword = swordObj.GetComponent<Sword>();
        this.nano = nanoObj.GetComponent<Nano>();
        
        // get original hand color
        // var handRenderer = this.hand.GetComponent<Renderer>();
        // this.handColor = handRenderer.material.GetColor("_Color");
        
        // initialize nanite timer
        startTime = Time.time;
        healingAlert.SetActive(false);
        
        this.weapons = new Weapons[5]; 
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;
        this.weapons[4] = nano;
        
        // Initialize current weapon to strength
        this.currWeapon = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // if (naniteActivated && Time.time - startTime > 5)
        // {
        //     var handRenderer = this.hand.GetComponent<Renderer>();
        //     handRenderer.material.SetColor("Color", this.handColor);
        // }
        
        ///////////////////////////////////////////////////////////////////
        ///                    KeyBoard Inputs                          ///
        ///////////////////////////////////////////////////////////////////
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
            this.weapons[currWeapon].secureWeapon(); // terminate weapon use
        }
        ///////////////////////////////////////////////////////////////////
        ///                    end KeyBoard Inputs                      ///
        ///////////////////////////////////////////////////////////////////

    }

    /**
     * Iterates through the Weapons Array
     */
    public void arrayiterate()
    {
        Debug.Log("Array is being iterated");
        this.currWeapon++;
        if (this.currWeapon > 4) this.currWeapon = 0;

        // display current weapon on HUD
        this.weaponDisplay.text = this.weapons[currWeapon].weaponName();
        
    }

    /**
     * Calls the useWeapon method for selected weapon
     */
    public void useweapon()
    {
        float energyUsed = this.weapons[currWeapon].useWeapon();

        this.em.decreaseEnergy(energyUsed); // update energy 

        // if (currWeapon == 4)
        // {
        //     var handRenderer = this.hand.GetComponent<Renderer>();
        //     handRenderer.material.SetColor("Color", this.naniteColor);
        // }
    }
    
    /*
     * Calls the secureWeapon method for selected weapon
     */

    public void terminateweapon()
    {
        this.weapons[currWeapon].secureWeapon(); // terminate weapon use
    }

}
