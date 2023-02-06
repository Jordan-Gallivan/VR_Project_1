using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unibeam : Weapons
{
    public float energyUsage;

    private GameObject parent;
    private GameObject child;
    
    // Start is called before the first frame update
    void Start()
    {
        this.energyUsage = EnergyMeter.large;
        
        this.parent = this.gameObject;
        this.child = parent.transform.GetChild(0).gameObject;
        
        // y scale = extending the beam
        // this.parent.transform.localScale = new Vector3 (.5f, 0, .4f);
        var beam = this.child.GetComponent<MeshRenderer>();
        beam.enabled = false;
        var collider = this.child.GetComponent<Collider>();
        collider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override float useWeapon()
    {
        print("Unibeam works");
        // y scale = extending the beam
        // this.parent.transform.localScale = new Vector3 (.5f, 6, .4f);
        var beam = this.child.GetComponent<MeshRenderer>();
        beam.enabled = true;
        var collider = this.child.GetComponent<Collider>();
        collider.enabled = true;
        
        // void OnCollisionEnter(Collision collision)
        // {
        //     Destroy(collision.gameObject);
        // }
        
        return this.energyUsage;
    }
    public override void secureWeapon()
    {
        
        print("weapon secured");
        var beam = this.child.GetComponent<MeshRenderer>();
        beam.enabled = false;
        var collider = this.child.GetComponent<Collider>();
        collider.enabled = false;
        return;
    }
    public override string weaponName()
    {
        return "Unibeam";
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }


}
