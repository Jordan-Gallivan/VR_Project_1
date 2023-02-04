// using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{

  //Energy Values
  public static float maxEnergy = 100;
  public float currEnergy = 0;

  // Energy decrementation constants;
  public static float small = 5.0f;
  public static float medium = 10.0f;
  public static float large = 20.0f;

  // Color and Scale Values
  private Color fullEnergyColor = new Color(0.50f, 0.50f, .83f, .69f);
  private Color lowEnergyColor = new Color(1.0f, 0.82f, .26f, .76f);
  private Color emptyEnergyColor = new Color(0.92f, 0.14f, .10f, .69f);
  private float yScale = .15f;
  private float zScale = .01f;
  
  // Parent and Children
  private GameObject parent;
  private GameObject child;
  
  
  // Start is called before the first frame update
  void Start()
  {
    this.parent = this.gameObject;
    this.child = parent.transform.GetChild(0).gameObject;
    
    // Initialize Full Energy Meter
    this.parent.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);
    
    var energyRenderer = this.child.GetComponent<Renderer>();
    energyRenderer.material.SetColor("_Color", fullEnergyColor);
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (currEnergy < maxEnergy) {
      currEnergy += .1f;
      currEnergy = Mathf.Min(currEnergy, maxEnergy);
    }
    
    // GameObject parent = this.gameObject;
    // GameObject child = parent.transform.GetChild(0).gameObject;
    var energyRenderer = this.child.GetComponent<Renderer>();
    
    if (currEnergy < 10)
    {
      energyRenderer.material.SetColor("_Color", emptyEnergyColor);
    } else if (currEnergy < 40)
    {
      energyRenderer.material.SetColor("_Color", lowEnergyColor);
    }
    else
    {
      energyRenderer.material.SetColor("_Color", fullEnergyColor);
    }
    this.gameObject.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);


  }
  
  public void decreaseEnergy(float energyDecrementer)
  {
    currEnergy = Mathf.Max(0, currEnergy - energyDecrementer);
  }
}
