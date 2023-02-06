using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("destroyable"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
