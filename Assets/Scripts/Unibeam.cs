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

    // private Ray myRay;
    // private RaycastHit hit;
    // public GameObject objToInstantiate;
    
    // Start is called before the first frame update
    void Start()
    {
        // pull static value for large energy usage
        this.energyUsage = EnergyMeter.large;
        
        // establish parent and child objects
        this.parent = this.gameObject;
        this.child = parent.transform.GetChild(0).gameObject;
        
        // y scale = extending the beam
        // this.parent.transform.localScale = new Vector3 (.5f, 0, .4f);
        
        // de-activate mesh renderer and collider
        // var beam = this.child.GetComponent<MeshRenderer>();
        // beam.enabled = false;
        // var collider = this.child.GetComponent<Collider>();
        // collider.enabled = false;
        this.parent.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // if (Physics.Raycast(new Vector3(0f,0f,0f),new Vector3(0f,1f,0f),out hit,100f))
        // {
        //     
        // }
        
    }

    public override float useWeapon()
    {
        print("Unibeam works");
        // y scale = extending the beam
        // this.parent.transform.localScale = new Vector3 (.5f, 6, .4f);
       
        // activate mesh renderer and collider
        // var beam = this.child.GetComponent<MeshRenderer>();
        // beam.enabled = true;
        // var collider = this.child.GetComponent<Collider>();
        // collider.enabled = true;
        this.parent.SetActive(true);

        return this.energyUsage;
    }
    public override void secureWeapon()
    {
        
        print("weapon secured");
        
        // de-activate mesh renderer and collider
        // var beam = this.child.GetComponent<MeshRenderer>();
        // beam.enabled = false;
        // var collider = this.child.GetComponent<Collider>();
        // collider.enabled = false;
        this.parent.SetActive(false);
        return;
    }
    /**
     * Returns String of weapon name to be displayed in HUD
     */
    public override string weaponName()
    {
        return "UNIBEAM";
    }
    


}
