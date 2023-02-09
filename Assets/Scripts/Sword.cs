using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapons
{
    public float energyUsage;
    public GameObject swordObj;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = 0f;
        this.swordObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // add code here
    }

    public override float useWeapon()
    {
        this.swordObj.SetActive(true);
        return this.energyUsage;
    }
    public override void secureWeapon()
    {
        this.swordObj.SetActive(false);
        return;
    }
    public override string weaponName()
    {
        return "SWORD";
    }

    
    //THIS WAS DR. P's EXAMPLE BELOW
    //public void DoUseWeapon()
    //{
    //    Debug.Log("Sword Worked");
    //    useWeapon();
    //}

}
