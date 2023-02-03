using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private EnergyMeter em;
    private Pulse pulse;
    private Strength str;
    private Unibeam uni;
    private Sword sword;
    private Object[] weapons;
    private int currWeapon;
    
    // Start is called before the first frame update
    void Start()
    {
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
        this.pulse = GameObject.Find("Pulsar").GetComponent<Pulse>();
        this.str = GameObject.Find("Strength").GetComponent<Strength>();
        this.uni = GameObject.Find("Unibeam").GetComponent<Unibeam>();
        this.sword = GameObject.Find("Sword").GetComponent<Sword>();

        this.weapons = new Object[4];
        this.weapons[0] = str;
        this.weapons[1] = pulse;
        this.weapons[2] = uni;
        this.weapons[3] = sword;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
