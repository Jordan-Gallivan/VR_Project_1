using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{

  //Energy Values
  public static float maxEnergy = 100;
  public static float currEnergy = 100;

  // Energy decrementation constants;
  public Transform small;
  public Transform medium;
  public Transform large;

  // Color and Scale Values
  public Color fullEnergyColor = new Color(0.50f, 0.50f, .83f, .69f);
  public Color lowEnergyColor = new Color(1.0f, 0.82f, .26f, .76f);
  public Color emptyEnergyColor = new Color(0.92f, 0.14f, .10f, .69f);
  public float yScale = .15F;
  public float zScale = .01F;

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
    var energyRenderer = this.gameObject.GetComponent<Renderer>();
    energyRenderer.material.SetColor("_Color", lowEnergyColor);

  }

  // Update is called once per frame
  // void Update()
  // {
  //     totalTime += Time.deltaTime;
  //     if (totalTime > .7) {
  //       currEnergy -= 5;
        
  //     }

  //     energy.transform.localScale = new Vector3 ((currEnergy / maxEnergy), yScale, zScale);
      
  // }
}
