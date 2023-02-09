using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nano : Weapons
{
    public float energyUsage;
    public GameObject healingAlert;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = - EnergyMeter.small;
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        healingAlert.SetActive(true);
        return this.energyUsage;
    }
    public override void secureWeapon()
    {
        healingAlert.SetActive(false);
        return;
    }

    public override string weaponName()
    {
        return "NANITE";
    }
}
