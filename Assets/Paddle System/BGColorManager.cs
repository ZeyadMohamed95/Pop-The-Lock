using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGColorManager : MonoBehaviour
{
    public Color StartingColor;
    public Color loseColor;

    void Start()
    {
        ChangeToOriginalColor();
    }

    public void ChangeBGColor()
    {
        Camera.main.backgroundColor = loseColor;
    }
    public void ChangeToOriginalColor()
    {
        Camera.main.backgroundColor = StartingColor;
    }
}
