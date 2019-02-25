using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public AudioClip AudioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<DeathScript>().RespawnPoint = transform.position;
            other.GetComponent<DeathScript>().Color = ColorScript.ActiveColor;
            other.GetComponent<AudioSource>().clip = AudioClip;
            other.GetComponent<AudioSource>().Play();
        }
    }
}
