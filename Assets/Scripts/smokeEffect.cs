using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeEffect : MonoBehaviour
{
    public GameObject death_Smoke;
    public AudioClip explosion;
    // Start is called before the first frame update
    void Start()
    {
        //public GameObject deathSmoke;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        //this.gameObject.GetComponent<MeshCollider>().enabled = false;


        if(other.name.Equals("LeftPulse"))
        {
            GameObject.Instantiate(death_Smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().clip = explosion;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (other.name.Equals("RightPulse"))
        {
            GameObject.Instantiate(death_Smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().clip = explosion;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        if (other.name.Equals("Beam"))
        {
            GameObject.Instantiate(death_Smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().clip = explosion;
            this.gameObject.GetComponent<AudioSource>().Play();
        }

    }
}
