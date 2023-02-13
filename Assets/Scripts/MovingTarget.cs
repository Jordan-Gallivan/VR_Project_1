using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    private GameObject tgt;
    private float startTime;
    private float durration = 16f;
    public float xSpeed = 0;
    public float ySpeed = 0;
    public float zSpeed = 0;
    public Vector3 speed;

    public GameObject deathSmoke;
    // Start is called before the first frame update
    void Start()
    {
        this.startTime = Time.time;
        this.tgt = this.gameObject;
        this.speed = new Vector3(xSpeed, ySpeed, zSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.tgt.transform.Translate(this.speed);
        if (Time.time - startTime > durration)
        {
            xSpeed *= -1;
            ySpeed *= -1;
            zSpeed *= -1;
            startTime = Time.time;
            this.speed = new Vector3(xSpeed, ySpeed, zSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Left Pulse"))
        {
            GameObject.Instantiate(deathSmoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        else if(other.name.Equals("Right Pulse"))
        {
            GameObject.Instantiate(deathSmoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        else if(other.name.Equals("Beam"))
        {
            GameObject.Instantiate(deathSmoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }
}
