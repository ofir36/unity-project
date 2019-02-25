using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public int Score;
    public AudioClip AudioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        collider.GetComponent<ScoreScript>().AddScore(Score);
        collider.GetComponent<AudioSource>().clip = AudioClip;
        collider.GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
