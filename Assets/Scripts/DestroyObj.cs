using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject deathSmoke;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("destroyable"))
        {
            GameObject tgt = collision.gameObject;
            tgt.SetActive(false);
            
            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //this.gameObject.GetComponent<MeshCollider>().enabled = false;
            
            
            
        }
        
    }
}
