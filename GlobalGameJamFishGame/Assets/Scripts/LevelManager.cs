using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    GameObject blue;
    GameObject orange;
    private AmmountCheck ac1, ac2;
    public int blueScore, orangeScore;
    void Start()
    {
        blue = GameObject.Find("BlueCup");
        orange = GameObject.Find("OrangeCup");
        ac1 = blue.GetComponent<AmmountCheck>();
        ac2 = orange.GetComponent<AmmountCheck>();
        blueScore = ac1.AmmountCollected;
        orangeScore = ac2.AmmountCollected;
    }
   
}
