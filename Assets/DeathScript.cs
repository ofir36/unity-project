using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public Vector3 RespawnPoint;
    public Color Color;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Enemy")
        {
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Death();
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Death();
        }
    }


    void Death()
    {
        transform.position = RespawnPoint;
        ColorScript.ChangeColor(Color);
    }
}
