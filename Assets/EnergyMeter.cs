using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMeter : MonoBehaviour
{

  // public Transform thePlayer;
  public Transform small;
  public Transform medium;
  public Transform large;
  public static float maxEnergy = 100;
  public static float currEnergy = 100;
  public float grColor = 0;
  public float redColor = 0;
  public float blColor = 1;

  //change
  public float totalTime = 0;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
      totalTime += Time.deltaTime;
      if (totalTime > .7) {
        currEnergy -= 5;
        
      }

      GetComponenet<Transform> ().localScale = new Vector3 ((currEnergy / maxEnergy), 1, 1);
      
  }
}
