using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : Weapons
{
    public float energyUsage;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = EnergyMeter.medium;
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        // add code here
        return this.energyUsage;
    }
}
