using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : Weapons
{
    public float energyUsage;
    public GameObject pulseHand;

    public AudioClip pulseSound;
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = EnergyMeter.small;
        this.pulseHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        this.pulseHand.SetActive(true);
        return this.energyUsage;
        
        this.gameObject.GetComponent<AudioSource>().clip = pulseSound;
        this.gameObject.GetComponent<AudioSource>().Play();
    }
    public override void secureWeapon()
    {
        this.pulseHand.SetActive(false);
        return;
    }
    public override string weaponName()
    {
        return "PULSE";
    }
}
