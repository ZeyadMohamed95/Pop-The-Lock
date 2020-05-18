using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DotDecrement : MonoBehaviour
{
    public int DotsNumber=10; 
    TMPro.TextMeshPro DotsCount;

    public void DecreaseDots()
    {
        DotsNumber-- ;
        if(DotsNumber<0)
        {
            DotsNumber = 0;
        }
    }
    private void Start()
    {
        DotsCount = GetComponent<TMPro.TextMeshPro>();
    }
    private void Update()
    {
        DotsCount.text = DotsNumber.ToString();
    }
}
