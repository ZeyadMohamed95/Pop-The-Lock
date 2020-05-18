using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelTextUI : MonoBehaviour
{
    public GameData gamedata;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = "Level: "+gamedata.CurrentLevel.ToString();
    }

}
