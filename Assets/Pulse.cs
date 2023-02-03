using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : Weapons
{
    public float energyUsage;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = EnergyMeter.small;
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        return this.energyUsage;
    }
}
