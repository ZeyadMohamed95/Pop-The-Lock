using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotsTextUI : MonoBehaviour
{
    public GameData gamedata;
    TMPro.TextMeshPro textmesh;

    void Awake()
    {
        textmesh = GetComponent<TMPro.TextMeshPro>();
    }
    void Update()
    {
        textmesh.text =gamedata.NumberOfDots.ToString();
    }
}
