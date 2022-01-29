using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    GameObject blue;
    GameObject orange;
    private AmmountCheck ac1, ac2;
    private int blueScore, redScore;
    void Start()
    {
        //CODE BELOW IS TEMPORARLY OUT COMMENTED WIP
        //blue = GameObject.Find("BlueCup");
        //orange = GameObject.Find("OrangeCup");
        //ac1 = blue.GetComponent<AmmountCheck>();
        //ac2 = orange.GetComponent<AmmountCheck>();
        //blueScore = ac1.AmmountCollected;
        //redScore = ac2.AmmountCollected;

        blueScore = 0;
        redScore=0;

        Debug.Log("Red score: " + redScore + ", Blue score: " + blueScore);

    }

    private void Update()
    {
       
    }

    public void addRedScore()
    {
        redScore++;
        Debug.Log("Red score: " + redScore);
    }
    public void addBlueScore()
    {
        blueScore++;
        Debug.Log("Blue score" + blueScore);
    }

    public int getRedScore()
    {
        return redScore;
    }
    public int getBlueScore()
    {
        return blueScore;
    }
   
}
