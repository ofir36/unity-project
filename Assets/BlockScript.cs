using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        ColorScript.OnColorChange += ColorScript_OnColorChange;
        ColorScript_OnColorChange(ColorScript.ActiveColor);
    }

    void ColorScript_OnColorChange(Color newColor)
    {
        var renderer = GetComponent<MeshRenderer>();
        if (newColor == color)
        {
            GetComponent<BoxCollider>().enabled = true;
            var c = renderer.material.color;
            renderer.material.color = new UnityEngine.Color(c.r, c.g, c.b, 1);
        }
        else
        {
            GetComponent<BoxCollider>().enabled = false;
            var c = renderer.material.color;
            renderer.material.color = new UnityEngine.Color(c.r, c.g, c.b, 0.2f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
