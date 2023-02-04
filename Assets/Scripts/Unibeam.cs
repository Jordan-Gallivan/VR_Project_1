using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unibeam : Weapons
{
    public float energyUsage;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = EnergyMeter.large;
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        print("Unibeam works");
        return this.energyUsage;
    }
}
