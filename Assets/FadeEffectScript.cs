using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffectScript : MonoBehaviour
{
    public Text hellText;
    public float fadeSpeed = 5;
    public bool enterance = false;
    void Start()
    {
        hellText.color = UnityEngine.Color.white;
    }

    void Update()
    {
        ColorChange();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            enterance = true;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
            enterance = false;
    }

    private void ColorChange()
    {
        if (enterance)
            hellText.color = UnityEngine.Color.Lerp(hellText.color, UnityEngine.Color.white, fadeSpeed * Time.deltaTime);
        if (!enterance)
            hellText.color = UnityEngine.Color.Lerp(hellText.color, UnityEngine.Color.clear, fadeSpeed * Time.deltaTime);
    }
}
