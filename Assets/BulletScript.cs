using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Enemy")
        {
            Debug.Log("true");
            StartCoroutine(collision.collider.GetComponent<ExplodeScript>().SplitMesh(true));
        }
    }
}
