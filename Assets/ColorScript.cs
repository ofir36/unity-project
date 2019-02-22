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
    public static Color ActiveColor;
    public static event OnColorChange OnColorChange;

    static Dictionary<Color, UnityEngine.Color> colorDictionary = new Dictionary<Color, UnityEngine.Color>
    {
        {Color.Red, UnityEngine.Color.red },
         {Color.Blue, UnityEngine.Color.blue }
    };

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(Color.Blue);
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
