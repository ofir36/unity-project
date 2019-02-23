using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    public AudioClip AudioClip;

    AudioSource AudioSource;
    int Score;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();

        Score = 0;
        ScoreText.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore(int count)
    {
        Score += count;
        ScoreText.text = "Score: " + Score;
        AudioSource.clip = AudioClip;
        AudioSource.Play();
    }
}
