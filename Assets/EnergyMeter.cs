// using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{

  //Energy Values
  public static float maxEnergy = 100;
  public static float currEnergy = 0;
  
  // make method for energy decrements
  
  // Energy decrementation constants;
  public float small = 5.0f;
  public float medium = 10.0f;
  public float large = 20.0f;

  // Color and Scale Values
  public Color fullEnergyColor = new Color(0.50f, 0.50f, .83f, .69f);
  public Color lowEnergyColor = new Color(1.0f, 0.82f, .26f, .76f);
  public Color emptyEnergyColor = new Color(0.92f, 0.14f, .10f, .69f);
  public float yScale = .15f;
  public float zScale = .01f;

  // Initialize Variables for Energy Meter
  // public GameObject energy = this.gameObject;
  // public Renderer energyRenderer = energy.GetComponent<Renderer>();

  //change
  public float totalTime = 0;
  // Start is called before the first frame update
  void Start()
  {
    // Initialize Full Energy Meter
    this.gameObject.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);
    GameObject parent = this.gameObject;
    GameObject child = parent.transform.GetChild(0).gameObject;
    var energyRenderer = child.GetComponent<Renderer>();
    energyRenderer.material.SetColor("_Color", fullEnergyColor);

  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (currEnergy < maxEnergy) {
      currEnergy += .1f;
      currEnergy = Mathf.Min(currEnergy, maxEnergy);
    }
    
    this.gameObject.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);


      
      // totalTime += Time.deltaTime;
      // if (totalTime > .7) {
      //   currEnergy -= 5;
        
      // }

      // energy.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);
      
  }
  
  public static void(float energyDecrementer)
  {
    currEnergy -= energyDecrementer;

  }
}
