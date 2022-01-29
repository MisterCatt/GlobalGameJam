using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    GameObject blue;
    GameObject orange;
    private AmmountCheck ac1, ac2;
    public int blueAmmount, orangeAmmount;
    void Start()
    {
        blue = GameObject.Find("BlueCup");
        orange = GameObject.Find("OrangeCup");
        ac1 = blue.GetComponent<AmmountCheck>();
        ac2 = orange.GetComponent<AmmountCheck>();
        blueAmmount = ac1.AmmountCollected;
        orangeAmmount = ac2.AmmountCollected;
    }
   
}
