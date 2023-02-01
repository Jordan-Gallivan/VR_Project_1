using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnibeamBehavior : MonoBehaviour
{

    private EnergyMeter em;
    
    // Start is called before the first frame update
    void Start()
    {
        this.em = GameObject.Find("EnergyContainer").GetComponent<EnergyMeter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            em.decreaseEnergy(EnergyMeter.large);
        }
    }
}
