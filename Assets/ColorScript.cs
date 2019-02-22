using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Color
{
    Red,
    Blue
}

public delegate void OnColorChange(Color color);

public class ColorScript : MonoBehaviour
{
    public static Color ActiveColor = Color.Blue;
    public static event OnColorChange OnColorChange;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(Color.Blue);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ActiveColor == Color.Blue)
                ChangeColor(Color.Red);
            else
                ChangeColor(Color.Blue);
        }
    }

    void ChangeColor(Color color)
    {
        ActiveColor = color;
        OnColorChange(color);
    }
}
