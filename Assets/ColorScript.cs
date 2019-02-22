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
    public static Color ActiveColor = Color.Red;
    public static event OnColorChange OnColorChange;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(Color.Red);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void ChangeColor(Color color)
    {
        ActiveColor = color;
        OnColorChange(color);
    }
}
