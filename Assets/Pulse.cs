using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
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

    public void useWeapon()
    {
        
    }
}
